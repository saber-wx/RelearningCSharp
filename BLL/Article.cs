using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public  DateTime PubishTime { get;private set; }
        public User Author { get; set; }
        public void Publish()
        {
            PubishTime = DateTime.Now;
        }
    }
}
