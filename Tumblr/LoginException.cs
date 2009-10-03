using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumblr
{
    public class LoginException : Exception
    {
        public LoginException() : base("ログインに失敗しました。メールアドレスとパスワードを確認して下さい。")
        {
        }

        public LoginException(string message)
            : base(message)
        {
        }

        public LoginException(string message, Exception inner)
            : base(message)
        {
        }
    }
}
