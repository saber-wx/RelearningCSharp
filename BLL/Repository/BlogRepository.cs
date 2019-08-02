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

        //public new Blog Get(int id)
        //{
        //    ////显示加载：稍后（需要用到的时候）从数据库加载，但关联数据不能自动加载
        //    //Blog blog = entities.Single(u => u.Id == id);
        //    //_dbContext.Entry(blog) //让blog的管理数据具有显示加载的“资格”
        //    //    .Reference(b => b.Author) //显示的获取blog的Author
        //    //    .Load();//调用Load(),让"Author"融入blog
        //    //return blog;

        //    return entities
        //        .Include(e => e.Author)
        //        .Include(e => e.Posts)
        //            .ThenInclude(e=>e.Author)
        //        .Single(u => u.Id == id);

        //    //预先加载：不管会不会使用，不影响Sql语句的生成
        //    //return entities
        //    //    .Include(e=>e.Author)
        //    //    .Single(u => u.Id == id);
        //}


        public IQueryable<Blog> Get(int pageIndex, int pageSize)
        {
            return Paged(entities, pageIndex, pageSize);
        }

        public IQueryable<Blog> GetByAuthor(int authorId)
        {
            return entities.Where(e => e.Author.Id == authorId);

        }
    }
}
