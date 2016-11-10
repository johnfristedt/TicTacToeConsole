using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;
using TicTacToe.Interfaces;
using TicTacToe.Models;

namespace TicTacToe
{
    class Runtime2
    {
        public void Start()
        {
            Node[] grid = new Node[9];

            int input = int.Parse(Console.ReadLine());

            Node nodeToUse = grid[input - 1];

            //Node[,] grid = new Node[3, 3];

            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        grid[row, col] = new Node { Taken = false, Player = };
            //    }
            //}
        }
    }
}