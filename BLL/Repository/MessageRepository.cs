using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Repository;

namespace BLL.Repository
{
    public class MessageRepository:Repositorys<Message>
    {
        public MessageRepository(DbContext context) : base(context)
        {

        }

    }
}
