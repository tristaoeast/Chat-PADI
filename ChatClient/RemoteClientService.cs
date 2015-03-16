using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    class RemoteClientService : MarshalByRefObject, IChatClient
    {

        private ChatClientForm clientForm;

        public RemoteClientService(ChatClientForm form)
        {
            clientForm = form;
        }

        public delegate void DRSDV(string s);

        public void RecebeMsg(string msg)
        {
            clientForm.Invoke(new DRSDV(clientForm.addMsg), new Object[] {msg});
        }

        
    }
}
