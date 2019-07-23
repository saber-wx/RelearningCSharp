using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository 
    {
        public DbSet<User> _users { get; set; }

        public UserRepository()
        {
            _users.Add(user);
            SaveChanges();  
        }

        public void Save(User user)
        {
            return _users.Where(u => u.Name == userName).SingleOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17Help;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);


        }

        public Email GetEmailById(int id)
        {
            return _users.Where(u => u.Id == id).SingleOrDefault();
        }

    }
}
