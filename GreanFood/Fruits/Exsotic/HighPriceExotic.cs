using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class HighPriceExotic : ExsoticFruit
    {
        private Random _random = new Random();
        public override int Calories { get => _random.Next(100, 333); }
        public override int Price { get => _random.Next(1000, 9999); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" with high price");
        }
    }
}
