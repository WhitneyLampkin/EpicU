using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Value { get; set; }
        public int Score { get; set; }
        public bool Band { get; set; }
        public bool Bullseye { get; set; }

        Random random = new Random();
        public Dart(Random randomDart) { random = randomDart; }

        public int Throw()
        {
            Score = random.Next(0, 21);

            if (Score == 0)
            {
                Bullseye = true;

                calculateBullseye();
            }

            else
            {
                Band = true;

                calculateBand();
            }

            return Value;
        }

        public int calculateBand()
        {
            int dartScore = Score;

            if (random.NextDouble() < 0.05)
                { return Value = dartScore * 3; }

            else if (random.NextDouble() > 0.95)
                { return Value = dartScore * 2; }

            else
                { return Value = dartScore; }
        }

        public int calculateBullseye()
        {
            int dartScore = Score;

            if (random.NextDouble() > 0.05)
                { return Value = dartScore * 3; }
            else
                { return Value = dartScore * 2; }
        }
    }
}
