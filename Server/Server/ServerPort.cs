using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerPort
    {
        private int _Port;
        private Socket _Server;
        private List<Socket> _ClientList;
        private IPEndPoint _IPep;
        public ServerPort(int port)
        {
            Port = port;
            Server=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            ClientList = new List<Socket>();
            IPep = new IPEndPoint(IPAddress.Any, Port);
        }

        public int Port { get => _Port; set => _Port = value; }
        public Socket Server { get => _Server; set => _Server = value; }
        public IPEndPoint IPep { get => _IPep; set => _IPep = value; }
        public List<Socket> ClientList { get => _ClientList; set => _ClientList = value; }
    }
}
