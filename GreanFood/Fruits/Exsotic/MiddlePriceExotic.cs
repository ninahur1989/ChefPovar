using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class MiddlePriceExotic : ExsoticFruit
    {
        private Random _random = new Random();
        public override int Calories { get => _random.Next(40, 254); }
        public override int Price { get => _random.Next(800, 1000); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" with middle price");
        }
    }
}
