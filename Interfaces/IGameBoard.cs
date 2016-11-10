using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe.Interfaces
{
    interface IGameBoard
    {
        Node[,] Grid { get; set; }
        int CurrentRow { get; set; }
        int CurrentCol { get; set; }
        bool P1Turn { get; set; }
    }
}
