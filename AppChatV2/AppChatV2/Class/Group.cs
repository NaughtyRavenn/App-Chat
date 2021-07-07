using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChatV2.Class
{
    class Group
    {
        private string _ID;
        private string _Name;
        private int _Port;
        private List<User> _ListMember;

        public string Name { get => _Name; set => _Name = value; }
        public int Port { get => _Port; set => _Port = value; }
        public string ID { get => _ID; set => _ID = value; }
        public List<User> ListMember { get => _ListMember; set => _ListMember = value; }
    }
}
