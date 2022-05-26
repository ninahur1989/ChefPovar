using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class ExsoticFruit : Fruit
    {
        public override void Opportunities()
        {
            base.Opportunities();
            Console.Write(".Exsotic");
        }
    }
}
