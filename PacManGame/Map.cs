using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Text.RegularExpressions;

namespace PacManGame
{
    class Map
    {
        static int HEIGHT = 20;
        static int WIGHT = 40;

        public char[,] map { get; set; }

        private StreamReader file;

        public Map()
        {
            map = new char[HEIGHT, WIGHT];
        }

        public void LoadMap(string filename)
        {
            int w = 0, h = 0;
            int ch = 0;

            file = new StreamReader(filename);

            while(true)
            {
                ch = file.Read();

                // file.Read()는 텍스트의 마지막에서 -1를 반환한다
                if (ch == -1) 
                {
                    break;
                }

                // 텍스트에 개행문자 /r/n를 만나면 다음 문자로 넘어간다
                if (ch == 13 || ch == 10)
                {
                    continue;
                }

                // 텍스트가 int형으로 불러오기 때문에 char형으로 바꿔줘야 한다
                map[h, w] = Convert.ToChar(ch);

                w++;

                if(w >= WIGHT)
                {
                    h++;
                    w = 0;

                    if(h >= HEIGHT)
                    {
                        h = 0;
                    }
                }
            }
        }

        public void PrintMap()
        {
            for (int h = 0; h < HEIGHT; h++)
            {
                for(int w = 0; w < WIGHT; w++)
                {
                    //Console.Write(map[h, w]);
                    if (map[h, w] == '1')
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
