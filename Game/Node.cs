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

        public string GetGFX()
        {
            return Taken ? (Player == 1 ? "[X]" : "[O]") : "[ ]";
        }
    }
}
