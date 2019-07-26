using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Keyword:Entity
    {

        public string Name { get; set; }

        public IList<BlogToKeyword> Blogs { get; set; }
    }
}
