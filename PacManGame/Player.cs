using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Player
    {
        //player[0] = "◀";
        //player[1] = "◁";
        //player[2] = "▶";
        //player[3] = "▷";
        //player[4] = "▲";
        //player[5] = "△";
        //player[6] = "▼";
        //player[7] = "▽";
        public string[] playerImage = new string[8] { "◀", "◁", "▶", "▷", "▲", "△", "▼", "▽" };
        public int direction;
        public int x;
        public int y;

        public Player()
        {
            direction = 0;
            x = 0;
            y = 0;
        }
    }
}
