using sn4k3r.MVVM.Core;
using sn4k3r.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace sn4k3r.MVVM.ViewModel
{
    class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        private Server _server;

        public MainViewModel()
        { 
            this._server = new Server();
            this.ConnectToServerCommand = new RelayCommand(o => this._server.ConnectToServer(Username, Password), o => !string.IsNullOrEmpty(Username));
        }
    }
}
