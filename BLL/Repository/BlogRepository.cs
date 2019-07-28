using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    class BlogRepository : Repositorys<Blog>
    {
        public BlogRepository(DbContext context):base (context)
        {

        }


        public void Add(Post post)
        {
        }
    }
}
