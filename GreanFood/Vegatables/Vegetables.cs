using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class Vegetables : GreenFood
    {
        public override int Calories { get => 0; }
        public override int Price { get => 0; }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.Write(" + i am vegetables ");
        }
    }
}
