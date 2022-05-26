using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    internal class BestialityFood : MeatFood
    {
        private Random _random = new Random();
        public override int Calories { get => _random.Next(438, 3304); }
        public override int Price { get => _random.Next(5, 4351); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.Write(" i from a earth");
        }
    }
}
