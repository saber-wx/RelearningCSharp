using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class Writings:Entity
    {

        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }

        public string DiscriminatorType { get; set; }

        

    }
}
