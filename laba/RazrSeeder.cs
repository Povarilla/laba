using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class RazrSeeder
    {
        private Random random = new Random();

        public Разряд Generate()
        {
            return new Разряд { Разряд1 = random.Next(1,1000) };
        }
    }
}
