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
        IList<Blog> Get();
    }
}
