using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class GreenFood : Salat, IHaveSeeds, IStatus
    {
        public override int Calories { get => 0; }
        public override int Price { get => 0; }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" and associated with GREEN color ");
        }

        public new void HaveSeeds()
        {
            Console.WriteLine("i can include some seems (99%)");
        }
    }
}
