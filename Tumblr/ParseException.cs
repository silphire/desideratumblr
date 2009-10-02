using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumblr
{
    public class ParseException : Exception
    {
        public ParseException() : base("HTMLの解析に失敗しました")
        {
        }

        public ParseException(string message)
            : base(message)
        {
        }

        public ParseException(string message, Exception inner)
            : base(message)
        {
        }
    }
}
