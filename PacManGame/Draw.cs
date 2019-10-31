using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Draw
    {
        public void Print(int x, int y, string Image)
        {
            Console.SetCursorPosition(x * 2, y);
            Console.Write(Image);
        }

        public void TextPrint(int x, int y, string text)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}
