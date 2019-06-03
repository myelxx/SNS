using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    class ProfileAction : EntityBaseClass
    {
        List<User> _userList;
        public void DisplayProfile(User user)
        {
            foreach (var p in _userList)
            {
                Console.WriteLine(" User name: {0} \n Date: {1} {2} \n", p.Name, p.DateTimeCreated);
            }
        }
    }
}
