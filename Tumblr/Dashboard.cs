using System;
using System.IO;
using System.Net;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Collections.Generic;

namespace Tumblr
{
    public class Dashboard
    {
        private CookieCollection LoginCookie_;
        public string LoginCookie
        {
            get
            {
                string sc = "";
                foreach (Cookie c in LoginCookie_)
                {
                    if (sc.Length > 0)
                        sc += "; ";
                    sc += c.Name;
                    sc += "=";
                    sc += c.Value;
                }
                return sc;
            }

            set
            {
                LoginCookie_ = new CookieCollection();
                foreach (string set in value.Split(';')) 
                {
                    string[] elems = set.Split('=');
                    Cookie c = new Cookie(elems[0].Trim(), elems[1].Trim(), "/", "tumblr.com");
                    LoginCookie_.Add(c);
                }
            }
        }

        private string PrevPageLink;
        private string NextPageLink;
        private int CurrentPage_;
        public int CurrentPage
        {
            get
            {
                return CurrentPage_;
            }
        }

        private List<Post> Posts_;
        public List<Post> Post
        {
            get
            {
                return Posts_;
            }
        }

        public Dashboard()
        {
            CurrentPage_ = 1;
            PrevPageLink = "";
            NextPageLink = "";
        }

        /// <summary>
        /// Tumblrにログインするメソッド
        /// </summary>
        /// <param name="username">Tumblrのユーザー名</param>
        /// <param name="password">Tumblrのパスワード</param>
        public void Login(string username, string password)
        {
            // request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.tumblr.com/login");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = new CookieContainer();

            if (LoginCookie_ != null)
                request.CookieContainer.Add(LoginCookie_);

            // request parameters
            string param = "email=" + HttpUtility.UrlEncode(username);
            param += "&password=" + HttpUtility.UrlEncode(password);
            param += "&redirect_to=/dashboard";
            param += "\r\n\r\n";
            byte[] byteparam = Encoding.UTF8.GetBytes(param);
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(byteparam, 0, byteparam.Length);
            requestStream.Close();

            // response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if((response.StatusCode == HttpStatusCode.Found || response.StatusCode == HttpStatusCode.RedirectKeepVerb) && response.Headers["Location"].StartsWith("/login")) {
                throw new LoginException();
            } else {
                // 使わないので読み捨てる
                (new StreamReader(response.GetResponseStream())).ReadToEnd();
                //StreamReader responseReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                //string responseData = responseReader.ReadToEnd();
                //responseReader.Close();
            }

            LoginCookie_ = response.Cookies;
            if (LoginCookie_.Count <= 1)
                throw new LoginException();

            LoadPage("/dashboard/");
        }

        private void LoadPage(int page, int from)
        {
            string path = "/dashboard/" + page + "/" + from;
            LoadPage(path);
        }

        private void LoadPage(string url)
        {
            byte[] partialContent = new byte[1024];
            string content = "";
            int nRead;

            if (LoginCookie_ == null || LoginCookie_.Count == 0)
                return;

            // Dashboardのページを読み込む
            if (url[0] == '/')
                url = "http://www.tumblr.com" + url;
            else
                url = "http://www.tumblr.com/" + url;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(LoginCookie_);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            do
            {
                nRead = responseStream.Read(partialContent, 0, partialContent.Length);
                content += Encoding.UTF8.GetString(partialContent, 0, nRead);
            } while (nRead > 0);

            // ステートマシンの開始
            ReadTumblogs(content, 0);
        }

        /// <summary>
        /// Dashboardの1ページ分を抜き出す
        /// </summary>
        /// <param name="content">HTMLが入っている文字列</param>
        /// <param name="position">解析を始める文字列中の位置</param>
        /// <returns>取得したエントリの数</returns>
        private int ReadTumblogs(string content, int position)
        {
            int index, terminal;
            List<Post> posts = new List<Post>();
            Match m;

            // "<!-- START POSTS -->"まで読み飛ばす
            index = content.IndexOf("<!-- START POSTS -->");
            if (index == -1)
                throw new ParseException();

            terminal = content.IndexOf("<!-- END POSTS -->");
            if (terminal == -1)
                throw new ParseException();

            Regex entryclass = new Regex(@"((\w+)\s+)*");
            Regex idval = new Regex(@"(\d+)""");
            string listr = "<li id=\"post";
            string id;
            while ((index = content.IndexOf(listr, index)) != -1)
            {
                List<string> types = new List<string>();

                index += listr.Length;

                // IDの取得
                m = idval.Match(content, index);
                if (m.Groups.Count == 0)
                    break;
                id = m.Groups[1].ToString();
                index += m.Length;

                // classの取得
                string classstr = @"class=""";
                index = content.IndexOf(classstr, index);
                index += classstr.Length;
                while (index < terminal)
                {
                    string type;

                    while (char.IsWhiteSpace(content[index]))
                        ++index;
                    if (content[index] == '"')
                    {
                        ++index;
                        break;
                    }

                    type = "";
                    while (!char.IsWhiteSpace(content[index]) && content[index] != '"')
                    {
                        type += content[index];
                        ++index;
                    }
                    types.Add(type);
                }

                // Postの種類ごとに処理
                if (types.Contains("photo"))
                {
                    // 画像投稿
                    Photo aPhoto = new Photo(id, types);
                    aPhoto.Read(content, ref index);
                    posts.Add(aPhoto);
                }
                else if (types.Contains("quote"))
                {
                }
                else
                {
                }
            }

            // 前のページ・次のページへのリンクを取得
            index = terminal;
            LoadNeighborPages(ref content, ref index);

            Posts_ = posts;
            return posts.Count;
        }

        /// <summary>
        /// "Next Page", "Previous Page"の取得
        /// </summary>
        /// <param name="content">HTMLが入っている文字列</param>
        /// <param name="index">解析を開始する文字列中の位置</param>
        private void LoadNeighborPages(ref string content, ref int index)
        {
            Regex prevPagePattern = new Regex(@"<a id=""previous_page_link"" href=""([^""]*)""");
            Regex nextPagePattern = new Regex(@"<a id=""next_page_link"" href=""([^""]*)""");

            int startIndex = content.IndexOf("<div id=\"pagination\"", index);
            int endIndex = content.IndexOf("</div>", startIndex);

            for (index = startIndex; index < endIndex; )
            {
                int anchorStartIndex = content.IndexOf("<a ", index, endIndex - index);
                if (anchorStartIndex == -1)
                    break;
                int anchorEndIndex = content.IndexOf('>', anchorStartIndex, endIndex - anchorStartIndex);
                if (anchorEndIndex == -1)
                    break;
                int anchorLength = anchorEndIndex - anchorStartIndex;

                string hrefstr = "href=\"";
                int linkStartIndex = content.IndexOf(hrefstr, anchorStartIndex, anchorLength);
                if (linkStartIndex == -1)
                    break;
                linkStartIndex += hrefstr.Length;
                int linkEndIndex = content.IndexOf('"', linkStartIndex);
                if (linkEndIndex == -1)
                    break;
                string link = content.Substring(linkStartIndex, linkEndIndex - linkStartIndex);

                if (content.IndexOf(@"id=""previous_page_link""", anchorStartIndex, anchorLength) != -1)
                {
                    PrevPageLink = link;
                }
                else if (content.IndexOf(@"id=""next_page_link""", anchorStartIndex, anchorLength) != -1)
                {
                    NextPageLink = link;
                }
                else
                {
                    break;
                }

                index = anchorEndIndex + 1;
            }

            index = endIndex;
        }

        /// <summary>
        /// 前のページに移動する
        /// </summary>
        public void PrevPage()
        {
            if (PrevPageLink != null && PrevPageLink.Length > 0)
                LoadPage(PrevPageLink);
        }

        /// <summary>
        /// 次のページに移動する
        /// </summary>
        public void NextPage()
        {
            if (NextPageLink != null && NextPageLink.Length > 0)
                LoadPage(NextPageLink);
        }
    }
}
