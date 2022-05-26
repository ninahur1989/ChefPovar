using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class SeaFood : MeatFood, IAvailability
    {
        private Random _random = new Random();
        public SeaFood()
        {
        }

        public new bool Availability { get => false; }

        public override int Calories { get => _random.Next(300, 2000); }
        public override int Price { get => _random.Next(10, 94371); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.Write(" i from a sea");
        }
    }
}
