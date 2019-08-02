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
            //new PostRepository().Save(post);

            onblog.Posts.Add(post);
            new BlogRepository(Helper.context).Flush();
            return post;
        }
    }
}
