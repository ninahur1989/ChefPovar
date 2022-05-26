using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public class MeatFood : Salat
    {
        public MeatFood()
        {
            Spoiled status = new Spoiled();
            Status = status;
        }

        public override int Calories { get => 0; }
        public override int Price { get => 0; }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" and associated with RED color ");
        }
    }
}
