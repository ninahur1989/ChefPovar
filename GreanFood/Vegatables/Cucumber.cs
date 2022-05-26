using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class Cucumber : Vegetables, IHaveSeeds
    {
        public Cucumber()
        {
            Fresh status = new Fresh();
            Status = status;
        }

        public override int Calories { get => 36; }
        public override int Price { get => 23; }

        public new void HaveSeeds()
        {
            Console.WriteLine("i have ~100 in my side");
        }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" and look like cucumber");
        }
    }
}
