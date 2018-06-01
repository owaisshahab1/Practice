using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Model
{
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public bool AreCredentialsCorrect{ get; set; }
        public bool IsUserNameCorrect { get; set; }
        public bool IsPasswordCorrect { get; set; }
        public bool IsRoleCorrect { get; set; }
    }
}
