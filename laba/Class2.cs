using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class Class2
    {
        private Random random = new Random();
        private Random random1 = new Random();

        public Заказчик Generate()
        {
            return new Заказчик { ФИО = generateRandomString(random.Next(5, 15)), Номер = generateRandomString1(random.Next(9, 11)) };
        }
        private string generateRandomString(int length)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random1.Next(s.Length)]).ToArray());
        }

        private string generateRandomString1(int length)
        {

            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
