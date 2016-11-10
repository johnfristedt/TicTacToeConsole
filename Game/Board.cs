using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Board
    {
        public Node[,] Grid { get; private set; }

        public Board()
        {
            Grid = new Node[3, 3];

            LoopGrid((row, col) =>
            {
                Grid[row, col] = new Node { Taken = false, Player = 0, Selected = false };
            });
        }

        public void Render()
        {
            string board = "";

            LoopGrid((row, col) =>
            {
                board += Grid[row, col].GetGFX() + ((col == 2) ? "\n" : String.Empty);
            });

            Console.WriteLine(board);
        }

        private void LoopGrid(Action<int, int> action)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    action(row, col);
                }
            }
        }
    }
}
