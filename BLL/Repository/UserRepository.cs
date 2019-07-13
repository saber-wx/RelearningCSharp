using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    class UserRepository
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
    }
}
