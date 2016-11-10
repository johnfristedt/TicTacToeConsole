using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Models
{
    class Product : ISellable
    {
        public int Price { get; set; }
        public string ProductInformation { get; set; }
    }
}
