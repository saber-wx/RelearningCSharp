using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class BlogToKeyword
    {

        public int  BlogId { get; set; }
        public Blog Blog { get; set; }

        public int KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}
