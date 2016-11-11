using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Game
{
    class Board : IGameBoard
    {
        const int NUM_ROWS = 3;
        const int NUM_COLS = 3;

        public enum MoveDirection
        {
            Up,
            Right,
            Down,
            Left
        }

        public Node[,] Grid { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentCol { get; set; }
        public bool P1Turn { get; set; }

        public Board()
        {
            Initialize();
        }

        private void Initialize()
        {
            P1Turn = true;
            CurrentCol = CurrentRow = 0;

            Grid = new Node[NUM_ROWS, NUM_COLS];

            LoopGrid((row, col) =>
            {
                var selected = false;
                if (row == 0 && col == 0)
                    selected = true;

                Grid[row, col] = new Node { Taken = false, Player = 0, Selected = selected };
            });

            LoopGrid((row, col) =>
            {
                foreach (var node in Grid)
                {
                    var neighbour = Grid[]
                }

                Grid[row, col].Neighbours.Add(null);
            });
        }

        public void Render()
        {
            string board = "";


            LoopGrid((row, col) =>
            {
                Grid[row, col].Render(P1Turn);
                if (col == NUM_COLS - 1)
                    Console.WriteLine();
            });

            Console.WriteLine(board);
        }

        public void Move(MoveDirection direction)
        {
            Grid[CurrentRow, CurrentCol].Selected = false;

            switch (direction)
            {
                case MoveDirection.Up:
                    CurrentRow = Math.Max(0, CurrentRow - 1);
                    break;
                case MoveDirection.Right:
                    CurrentCol = Math.Min(NUM_COLS - 1, CurrentCol + 1);
                    break;
                case MoveDirection.Down:
                    CurrentRow = Math.Min(NUM_ROWS - 1, CurrentRow + 1);
                    break;
                case MoveDirection.Left:
                    CurrentCol = Math.Max(0, CurrentCol - 1);
                    break;
            }

            Grid[CurrentRow, CurrentCol].Selected = true;
        }

        public void PlaceMarker()
        {
            if (!Grid[CurrentRow, CurrentCol].Taken)
            {
                Grid[CurrentRow, CurrentCol].Player = P1Turn ? 1 : 2;
                Grid[CurrentRow, CurrentCol].Taken = true;
                P1Turn = !P1Turn;

                GameUtils.WinCheck(Grid);
            }
        }

        private void LoopGrid(Action<int, int> action)
        {
            for (int row = 0; row < NUM_ROWS; row++)
            {
                for (int col = 0; col < NUM_COLS; col++)
                {
                    action(row, col);
                }
            }
        }
    }
}
