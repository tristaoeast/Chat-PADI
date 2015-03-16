using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class RemoteServerService : MarshalByRefObject, IChatServer
    {

        private ChatServer chatServer;

        public RemoteServerService(ChatServer cs)
        {
            chatServer = cs;
        }

        public string Reg(string cli, string url)
        {
            chatServer.RegisterUser(cli,url);
            return "Registered with server successfully.";
        }

        public void SendMsg(string cli, string msg)
        {
        }
    }
}
