using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class ChatServer
    {

        private Dictionary<string, string> urlMap = new Dictionary<string, string>();

        static void Main(string[] args)
        {

            ChatServer cs = new ChatServer();
            TcpChannel channel = new TcpChannel(8086);
            ChannelServices.RegisterChannel(channel, true);
            //RemotingConfiguration.RegisterWellKnownServiceType(
                //typeof(RemoteServerService),
                //"IChatServer",
                //WellKnownObjectMode.Singleton);

            RemoteServerService rss = new RemoteServerService(cs);
            RemotingServices.Marshal(rss, "IChatServer", typeof(IChatServer));

            Console.ReadLine();

        }

        public void RegisterUser(string nick, string url)
        {
            urlMap.Add(nick, url);
        }


    }
}
