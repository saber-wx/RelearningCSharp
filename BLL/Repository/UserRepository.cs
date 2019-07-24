using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository 
    {
        private SQLContext _sqlcontext;



        public UserRepository()
        {
            _sqlcontext = new SQLContext();
        }

        public void Save(User user)
        {
            _sqlcontext._users.Add(user);
            _sqlcontext.SaveChanges();
        }

        public void Save(Email email)
        {
            //_sqlcontext.Emails.Add(email);
            _sqlcontext.SaveChanges();
        }

        public Email GetEmailById(int id)
        {
            return null;
            //return _sqlcontext.Emails.Where(e => e.Id == id).SingleOrDefault();
        }

        public User GetByName(string userName)
        {
            
            return _sqlcontext._users.Where(u => u.Name == userName).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return _sqlcontext._users.Where(u => u.Id == id).SingleOrDefault();
        }

        public void Flush()
        {
            _sqlcontext.SaveChanges();
        }


    }
}
