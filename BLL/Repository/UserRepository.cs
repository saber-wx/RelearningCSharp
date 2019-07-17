using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository : DbContext
    {
        public DbSet<User> _users { get; set; }

        public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();  
        }

        public User GetByName(string userName)
        {
            return _users.Where(u => u.Name == userName).SingleOrDefault();
        }
    }
}
