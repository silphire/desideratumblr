using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumblr
{
    public class Post
    {
        protected string ID_;
        public string ID
        {
            get
            {
                return ID_;
            }
            set
            {
                ID_ = value;
            }
        }

        protected List<string> Types_;
        public List<string> Types
        {
            get
            {
                return Types_;
            }
            set
            {
                Types_ = value;
            }
        }

        protected string SourceURL_;
        public string SourceURL
        {
            get
            {
                return SourceURL_;
            }
            set
            {
                SourceURL_ = value;
            }
        }

        public Post()
        {
        }

        public Post(string id, List<string> types)
        {
            this.ID = id;
            this.Types = types;
        }
    }
}
