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
        PostRepository p = new PostRepository();

        List<User> _userList;
        public User Add(User user)
        {
            //User user1 = new User {
            //    UserId = new Guid()
            //};

           _userList.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            User user = _userList.First(e => e.UserId == id);

            if (user != null)
            {
                _userList.Remove(user);
            }

            return user;
        }

        public void Edit(User user)
        {
            User editUser = _userList.First(p => p.UserId == user.UserId);

            if (editUser != null)
            {
                user.Name = editUser.Name;
            }

        }

        public User View(User user)
        {
            foreach (var p in _userList)
            {
                Console.WriteLine(" User name: {0} \n Date: {1} {2} \n", p.Name, p.DateTimeCreated);
            }

            return user;
        }


    }
}
