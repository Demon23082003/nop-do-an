using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ungdunghoctumoi
{
    [Serializable]
    public class User
    {
        private string _Email;
        private string _Password;
        public User()
        {
            this._Email = " ";
            this._Password = " ";
        }
        public User(string email, string password)
        {
            _Email = email;
            _Password = password;
        }
        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }
        public string Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }

    }

}

