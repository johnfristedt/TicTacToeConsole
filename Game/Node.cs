using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Node
    {
        public bool Taken { get; set; }
        public int Player { get; set; }
        public bool Selected { get; set; }
        public int Worth { get; set; }
        public List<Node> Neighbours { get; set; }

        public void Render(bool p1Turn)
        {
            if (Selected)
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

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void WinCheck()
        {
            Task.Factory.StartNew(() =>
            {

                return 1;
            });
        }
    }
}
