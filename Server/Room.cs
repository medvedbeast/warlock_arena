﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace WarlockArena2DServer
{
    class Room
    {
        public int maximumPlayers;
        public List<Player> players = new List<Player>();
    }
}
