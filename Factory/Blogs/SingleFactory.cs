using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Blogs
{
    class SingleFactory
    {
        internal static void Create()
        {
            comment(Blogs.NewFactory.blogs[0], "666", RegisterFactory.Lancer);
            comment(Blogs.NewFactory.blogs[1], "666", RegisterFactory.Caster);
            comment(Blogs.NewFactory.blogs[2], "666", RegisterFactory.Saber);
            comment(Blogs.NewFactory.blogs[3], "666", RegisterFactory.Caster);
        }

        private static BLL.Post comment(BLL.Blog onblog,string content,BLL.User author)
        {
            BLL.Post post = new BLL.Post
            {
                Blog = onblog,
                BlogId = onblog.Id,
                Content = content,
                Author = author
            };
            //onblog.Publish();
            ////面向数据库：
            //new PostRepository(Helper.context).Save(post);

            //面向对象写法：
            onblog.Posts = onblog.Posts ?? new List<BLL.Post>();
            onblog.Posts.Add(post);
            new BlogRepository(Helper.context).Flush();

            return post;
        }
    }
}
