﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<BlogToKeyword> Blogs { get; set; }
    }
}
