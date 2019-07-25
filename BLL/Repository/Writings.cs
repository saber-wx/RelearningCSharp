using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class Writings
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public string Url { get; set; }

        public string DiscriminatorType { get; set; }

        

    }
}
