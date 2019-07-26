﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public class Article:Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public  DateTime PubishTime { get;private set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }
        public void Publish()
        {
            PubishTime = DateTime.Now;
        }
    }
}
