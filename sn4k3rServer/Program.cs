﻿using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;


namespace sn4k3rServer
{
    class Program
    {
        static List<Client> _users;
        static TcpListener _listener;
        static void Main(string[] args)
        {
            _users = new List<Client>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7891);
            _listener.Start();

            while (true)
            {
                var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);

                /*Broadcast the connection to everyone on the server*/
            }
        }
    }
}