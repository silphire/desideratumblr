using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tumblr
{
    public class Photo : Post
    {
        private string DisplayImageURL_;
        public string DisplayImageURL
        {
            get
            {
                return DisplayImageURL_;
            }
            set
            {
                DisplayImageURL_ = value;
            }
        }

        public Photo(string id, List<string> types) : base(id, types)
        {
        }

        public void Read(string buffer, ref int startIndex)
        {
            int index = startIndex;
            string startPostString = "<!-- Share post -->";
            string divString = "<div>";
            Regex imagePattern = new Regex(@"<a href=""([^""]*)"".*?src=""([^""]*)""", RegexOptions.Singleline);
            Match m;

            index = buffer.IndexOf(startPostString, index);
            index += startPostString.Length;
            index = buffer.IndexOf(divString, index);
            index += divString.Length;

            m = imagePattern.Match(buffer, index);
            if(m.Success && m.Groups.Count > 2) {
                this.SourceURL = m.Groups[1].ToString();
                this.DisplayImageURL = m.Groups[2].ToString();
            }

            startIndex = index;
            System.Console.WriteLine("Photo " + ID + " " + SourceURL + " " + DisplayImageURL);
        }
    }
}
