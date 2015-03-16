using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib;
using System.Net.Sockets;

namespace ChatClient
{
    public partial class ChatClientForm : Form
    {

        
        string local_port;
        string server_url = "tcp://localhost:8086/IChatServer";
        string nick;
        string reg_status;

        public ChatClientForm()
        {
            InitializeComponent();
        }

        public void addMsg(string s)
        {
            tb_conversation.AppendText(s+"\r\n");
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            local_port = tb_port.Text;
            tb_conversation.AppendText(local_port+"\r\n");
            if (!string.IsNullOrWhiteSpace(tb_url.Text))
            {
                server_url = tb_url.Text;
            }
            tb_conversation.AppendText(server_url + "\r\n");
            nick = tb_nick.Text;
            tb_conversation.AppendText(nick+"\r\n");
            
            TcpChannel channel = new TcpChannel();
			ChannelServices.RegisterChannel(channel,true);
            IChatServer server = (IChatServer) Activator.GetObject(
				typeof(IChatServer),
				server_url);

	 		try
	 		{
	 			reg_status = server.Reg(nick,"tcp://localhost"+local_port+"/IChatClient");
                tb_conversation.AppendText(reg_status+"\r\n");
	 		}
	 		catch(SocketException)
	 		{
	 			System.Console.WriteLine("Could not locate server");
	 		}

			Console.ReadLine();

        }


    }
}
