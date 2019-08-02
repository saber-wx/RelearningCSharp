
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Blog : Writings
    {
        public string Url { get; set; }

        public virtual IList<Post> Posts { get; set; }

        public virtual IList<BlogToKeyword> Keywords { get; set; }

        public void Publish()
        {

        }
    }


    public class Post : Entity
    {
       

        public virtual User Author { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }//如果不声明的话，就会产生“影子”属性
        public virtual  Blog Blog { get; set; }
    }
}
