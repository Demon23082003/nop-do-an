using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ungdunghoctumoi
{
    [Serializable]
    internal class DanhSachUser
    {
        private List<User> _dsUser;
        public DanhSachUser()
        {
            _dsUser = new List<User>();
        }
        public DanhSachUser(List<User> dsUser)
        {
            _dsUser = dsUser;
        }
        public List<User> DsUser
        {
            get { return this._dsUser.ToList(); }
            set { this._dsUser = value; }
        }
    }
}
