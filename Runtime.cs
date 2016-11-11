using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe
{
    class Runtime
    {
        public Board Board { get; set; }
        public void Start()
        {
            Board = new Board();
            var gameOver = false;

            while (!gameOver)
            {
                Render();
                Update();
            }
        }

        public void Update()
        {
            var input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    Board.Move(Board.MoveDirection.Up);
                    break;
                case ConsoleKey.RightArrow:
                    Board.Move(Board.MoveDirection.Right);
                    break;
                case ConsoleKey.DownArrow:
                    Board.Move(Board.MoveDirection.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    Board.Move(Board.MoveDirection.Left);
                    break;
                case ConsoleKey.Enter:
                    Board.PlaceMarker();
                    break;
            }
        }

        public void Render()
        {
            Console.Clear();
            Board.Render();
        }
    }
}
