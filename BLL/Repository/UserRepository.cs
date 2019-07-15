using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository
    {
        private static IList<User> _users;
        private static int _idCounter;
        public User Save(User user)
        {
            _users = _users ?? new List<User>();
            _idCounter++;
            user.Id = _idCounter;
            _users.Add(user);
            return user;
        }

        public User GetByName(string userName)
        {
            return _users == null ? null:
                _users.Where(u => u.Name == userName)
                .SingleOrDefault();
        }
    }
}
