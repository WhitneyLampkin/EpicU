using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();

        public int Value { get; set; }
        public int Score { get; set; }
        public bool Band { get; set; }
        public bool Bullseye { get; set; }

        public Dart(Random random) { }

        public int Throw()
        {
            Dart dart = new Dart(random);

            dart.Score = random.Next(20);

            if (dart.Score == 0)
            {
                dart.Band = false;
                dart.Bullseye = true;

                calculateBullseye(dart);
            }

            else
            {
                dart.Band = true;
                dart.Bullseye = false;

                calculateBand(dart);
            }
            return dart.Value;
        }

        public int calculateBand(Dart dart)
        {
            int dartScore = dart.Score;

            if (random.NextDouble() < 0.05)
                { return dart.Value = dartScore * 3; }

            if (random.NextDouble() > 0.95)
                { return dart.Value = dartScore * 2; }

            else
                { return dart.Value = dartScore; }
        }

        public int calculateBullseye(Dart dart)
        {
            int dartScore = dart.Score;

            if (random.NextDouble() > 0.05)
                { return dart.Value = dartScore * 3; }
            else
                { return dart.Value = dartScore * 2; }
        }
    }
}
