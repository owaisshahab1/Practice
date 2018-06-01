using DbDemo.Model;
using DbDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Service
{
    public class LoginService
    {
        public static void Authenticated(LoginUser loginUser)
        {
            LoginRepository.Authenticated(loginUser);
        }

        public static void GetAllRoles(List<UserRole> userRole)
        {
            LoginRepository.GetAllRoles(userRole);
        }
    }
}
