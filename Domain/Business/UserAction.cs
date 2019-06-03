using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entity;
using Domain.Repository;

namespace Domain.Business
{
    class UserAction : EntityBaseClass
    {
        List<User> _userContext;
        public User Add(User user)
        {
           _userContext.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            User user = _userContext.FirstOrDefault(e => e.UserId == id);

            if (user != null)
            {
                _userContext.Remove(user);
            }

            return user;
        }

        public void Edit(User user)
        {
            User editUser = _userContext.FirstOrDefault(e => e.UserId == user.UserId);

            if (editUser != null)
            {
                user.Name = editUser.Name;
            }

        }

        public User View(User user)
        {
            foreach (var p in _userContext)
            {
                Console.WriteLine(" User name: {0} \n Date: {1} {2} \n", p.Name, p.DateTimeCreated);
            }

            return user;
        }


    }
}
