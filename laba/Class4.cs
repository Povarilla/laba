using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
   class Class4
    {
        private Random random = new Random();


        public Готовка_пиццы Generate()
        {
            return new Готовка_пиццы { Пицца = random.Next(1, 11), Заказчик = random.Next(1, 9), Пиццайоло = random.Next(1, 9), Цена = random.Next(1, 10000) };
        }
       
    }
}
