using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class Class1
    {
        private Random random = new Random();


        public Пицца Generate()
        {
            return new Пицца { Пицца1 = generateRandomString(random.Next(5, 15)), Состав = generateRandomString(random.Next(20, 35)) };
        }
        private string generateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
