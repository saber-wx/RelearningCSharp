using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository : Repositorys
    {
       
        public void Save(User user)
        {
            CurrentContext._users.Add(user);
            CurrentContext.SaveChanges();
        }

        public void Save(Email email)
        {
            CurrentContext.Emails.Add(email);
            CurrentContext.SaveChanges();
        }

        public Email GetEmailById(int id)
        {

            return CurrentContext.Emails.Where(e => e.Id == id).SingleOrDefault();
        }

        public User GetByName(string userName)
        {
            return CurrentContext._users.Where(u => u.Name == userName).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return CurrentContext._users.Where(u => u.Id == id).SingleOrDefault();
        }
        
    }
}
