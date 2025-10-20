using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DzAlekseeva
{
    internal class Dice1
    {
        private int _sides;

        public Dice1(int sides = 6)
        {
            _sides = sides;
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, _sides + 1);
        }
    }
}