using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    class BlogRepository : Repositorys
    {
        public BlogRepository()
        {
            //CurrentContext = new SQLContext(new Microsoft.EntityFrameworkCore.DbContextOptions<SQLContext>);
            var optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            string connectionString =
    @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17Help; Integrated Security = True; ";
            optionsBuilder.UseSqlServer(connectionString);
            using (var context = new SQLContext(optionsBuilder.Options))
            {

            }
        }

        public void Save(Blog blog)
        {
            //CurrentContext.Blogs.Add(blog);

            //CurrentContext = new SQLContext(new )
        }

        public void Add(Post post)
        {
            //CurrentContext.Blogs.Where
        }
    }
}
