using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Node
    {
        const bool DEBUG = true;

        public bool Taken { get; set; }
        public int Player { get; set; }
        public bool Selected { get; set; }
        public int Worth { get; set; }

        public void Render(bool p1Turn)
        {
            if (!DEBUG && Selected)
            {
                if (p1Turn)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                { 
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
            }

            Console.Write(Taken ? (Player == 1 ? "[X]" : "[O]") : "[ ]");

            if (DEBUG)
            {

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
