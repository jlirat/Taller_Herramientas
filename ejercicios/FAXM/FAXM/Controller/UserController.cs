using FAXM.Model;
using FAXM.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FAXM.Controller
{
    public class UserController
    {
        UserService service = new UserService();

        public bool Login(User user)
        {
            if (user == null) return false;
            if (string.IsNullOrEmpty(user.Username)) return false;
            if (string.IsNullOrEmpty(user.Pass)) return false;
            return service.login(user);
        }

    }
}
