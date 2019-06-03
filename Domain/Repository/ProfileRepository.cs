using Domain.Business;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    class ProfileRepository : ProfileAction
    {
        Profile _profileContext;
        List<User> _userContext;
        public ProfileRepository(Profile profileContext)
        {
            _profileContext = profileContext;
        }

        public void DisplayProfile(User user)
        {
            throw new NotImplementedException();
        }

    }
}
