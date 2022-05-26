using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class Banana : Fruit, IHaveSeeds, IStatus
    {
        public Banana()
        {
            Fresh status = new Fresh();
            Status = status;
        }

        public override int Calories { get => 100; }
        public override int Price { get => 40; }

        public new void HaveSeeds()
        {
            Console.WriteLine("i dont have any seems in my side");
        }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" and look like banana");
        }
    }
}
