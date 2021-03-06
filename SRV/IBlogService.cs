using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRV
{
    public interface IBlogService
    {
        Blog Publish(Blog dBlog);
        Blog Get(int id);
        IList<Blog> Get(int? bloggerId, int pageIndex, int pageSize);
        void Delete(int id);
        void Comment(int Id, Post newPost);
    }
}
