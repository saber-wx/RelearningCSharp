using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public  class BlogToKeyword
    {

        public int  BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public int KeywordId { get; set; }
        public virtual  Keyword Keyword { get; set; }
    }
}
