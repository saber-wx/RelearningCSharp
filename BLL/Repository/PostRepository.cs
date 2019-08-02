using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class PostRepository : Repositorys<Post>
    {
        public PostRepository(DbContext context) : base(context)
        {

        }
    }
}
