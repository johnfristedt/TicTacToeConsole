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

                    break;
                case ConsoleKey.RightArrow:

                    break;
                case ConsoleKey.DownArrow:

                    break;
                case ConsoleKey.LeftArrow:

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
