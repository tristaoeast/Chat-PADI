using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IChatServer
    {
        void SendMsg(string cli, string msg);
        string Reg(string cli, string url);
    }
}
