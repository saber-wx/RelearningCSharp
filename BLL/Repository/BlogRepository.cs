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

        public IList<Blog> Get(int pageIndex, int pageSize)
        {
            return Paged(entities.ToList(), pageIndex, pageSize);
        }
        
        public IList<Blog> GetByAuthor(int authorId, int pageIndex, int pageSize)
        {
            return entities
                .Where(e => e.Author.Id == authorId)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

        }
    }
}
