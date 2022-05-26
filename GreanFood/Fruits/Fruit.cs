using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class Fruit : GreenFood
    {
        public override void Opportunities()
        {
            base.Opportunities();
            Console.Write(" + i am fruit ");
        }
    }
}
