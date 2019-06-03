using Domain.Business;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    class UserRepository : UserAction
    {

        User _userContext;

        List<User> users = new List<User>()
        {
            new User () { UserId = 1, Name = "Meji", DateTimeCreated = DateTime.Now },
            new User () { UserId = 2, Name = "Teya", DateTimeCreated = DateTime.Now },
            new User () { UserId = 3, Name = "Je-an", DateTimeCreated = DateTime.Now },
            new User () { UserId = 2, Name = "Teya", DateTimeCreated = DateTime.Now },
        };
        public UserRepository(User userContext)
        {
            _userContext = userContext;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(User entity)
        {
            throw new NotImplementedException();
        }


    }
}
