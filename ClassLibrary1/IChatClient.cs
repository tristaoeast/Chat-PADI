﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IChatClient
    {
        void RecebeMsg(string msg);
    }
}
