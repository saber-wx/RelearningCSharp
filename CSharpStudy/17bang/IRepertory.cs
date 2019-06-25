using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{

    interface IRepository<T>
    {
        List<T> Get();

    }
    interface IArticleRepository : IRepository<Article>
    {

    }
}
