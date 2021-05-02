using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class Player
    {
        private readonly double[] _frequency;
        public double score = 0;

        public Player(double[] frequency)
        {
            this._frequency = frequency;
        }

        public int RollDice()
        {
            Random _random = new Random();
             var stats = 0;
             var q = (double)_random.NextDouble();
            for (int j = 0; j < _frequency.Length; j++)
            {
                q -= _frequency[j];
                if (!(q <= 0)) continue;
                stats = j + 1;
                break;
            }
            
            return stats;
        }
    }
}
