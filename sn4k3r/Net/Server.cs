using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace sn4k3r.Net
{
    class Server
    {
        TcpClient tcpClient;

        public Server()
        {
            this.tcpClient = new TcpClient();
        }

        public void ConnectToServer(string username)
        {
            if (!this.tcpClient.Connected)
            {
                this.tcpClient.Connect("127.0.0.1", 7891);
            }
        }
    }
}
