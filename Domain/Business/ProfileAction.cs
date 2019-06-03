using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    class ProfileAction : EntityBaseClass
    {
        List<User> _userContext;
        public void DisplayProfile(User user)
        {
            foreach (var p in _userContext)
            {
                Console.WriteLine(" User name: {0} \n Date: {1} {2} \n", p.Name, p.DateTimeCreated);
            }
        }
    }
}
