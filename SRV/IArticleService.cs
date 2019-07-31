using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRV
{
    public interface IArticleService
    {
        Article Publish(DTOArticle dArticle);
        DTOArticle Get(int id);
    }
}
