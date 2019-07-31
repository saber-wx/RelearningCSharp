using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class BlogRepository : Repositorys<Blog>
    {
        public BlogRepository(DbContext context) : base(context)
        {

        }


        public void Add(Post post)
        {
        }

        public IList<Blog> Get()
        {
            return entities.ToList();
        }
    }
}
