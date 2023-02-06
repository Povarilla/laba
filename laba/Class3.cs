using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
     class Class3
    {
        private Random random = new Random();


        public Пиццайоло Generate()
        {
            return new Пиццайоло { ФИО = generateRandomString(random.Next(5, 15)), Разряд = random.Next(1, 8) };
        }
        private string generateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
