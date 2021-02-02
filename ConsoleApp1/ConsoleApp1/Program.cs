    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MapHandler map1;
            map1 = new MapHandler();
            map1.setName("Elso palya");
            Console.WriteLine(map1.getName());
            map1.showmap();

            bool gameIsRunning=true;
            while (gameIsRunning)
            {
                char command = Console.ReadKey(true).KeyChar;
                switch (command)
                {
                    case 'w': map1.up(); break;
                    case 's': map1.down(); break;
                    case 'a': map1.left(); break;
                    case 'd': map1.right(); break;
                    case 'f': Console.WriteLine(
                        map1.findMe()[0] + "|"+map1.findMe() [1]); ; break;
                    default: Console.WriteLine("Hibás parancs!"); break;
                }
            }

            Console.ReadKey();
        }
    }
    class MapHandler
    {
        String mapname;
        char[,] map = {
            {'#','@','#','#','#'},
            {'#','.','.','.','#'},
            {'#','#','.','#','#'},
            {'#','.','.','.','#'},
            {'#','#','#','x','#'}
        };

        public MapHandler()
        {

        }
        public void setName(String name)
        {
            this.mapname = name;
        }
        public String getName()
        {
            return mapname;
        }
        public void showmap()
        {
            int meret = this.map.GetLength(0);
            for (int row = 0; row < meret; row++)
            {
                for (int col= 0; col < meret; col++)
                {
                    Console.Write(this.map[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
        public int[] findMe()
        {
            int[] pos= { 0, 0 };
            int meret = this.map.GetLength(0);
            for (int row = 0; row < meret; row++)
            {
                for (int col = 0; col < meret; col++)
                {
                    if(this.map[row, col] == '@')
                    {
                        pos[0] = row;
                        pos[1] = col;
                        return pos; ;
                    }
                }
                Console.WriteLine();
            }
            return pos;

        }
        public void up()
        {

        }
        public void down()
        {

        }
        public void left()
        {

        }
        public void right()
        {

        }


    }
}
