using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class EmailRepository : Repositorys<Email>
    {
   

        public Email GetEmailById(int id)
        {
            return entities.Where(e => e.Id == id).SingleOrDefault();
        }


    }
}
