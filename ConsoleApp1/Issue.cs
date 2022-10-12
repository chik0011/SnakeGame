using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Issue
    {
        private int min;
        private int max;
        private Random random;

        public Issue(int min, int max, Random random)
        {
            this.min = min;
            this.max = max;
            this.random = random;
        }

        public int getRandomNumber()
        {
            return  this.random.Next(this.min, this.max);
        }

        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
    }
}
