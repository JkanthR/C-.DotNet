using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWinFormsBasic
{
    class LoginDTO
    {
        public string User_Name { get; set; }

        public string Pass_Word { get; set; }

        public LoginDTO(string user, string password)
        {
            this.User_Name = user;
            this.Pass_Word = password;
        }
    }
}
