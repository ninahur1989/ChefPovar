using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    internal class Initialiser
    {
        public Salat[] Initialise()
        {
            Salat salat1 = new Banana();
            Salat salat2 = new SeaFood();
            Salat salat3 = new MiddlePriceExotic();
            Salat salat4 = new HighPriceExotic();
            Salat salat5 = new BestialityFood();
            Salat[] salats = new Salat[] { salat1, salat2, salat3, salat4, salat5 };
            Array.Sort(salats);
            for (int i = 0; i < salats.Length; i++)
            {
                Console.WriteLine("i am " + salats[i].GetType());
                salats[i].SeedsCheck(salats[i]);
            }

            void CheckFoodStatus(IStatus status)
            {
                Console.WriteLine("i am " + status.GetType());
                if (status == null)
                {
                    throw new BusinessException("error status");
                }
                else
                {
                    Console.WriteLine("this food has a status for more deteils you can answet the chef");
                }
            }

            Console.WriteLine("write 'yes' if you want to check meat status and availability of seafood for now");
            string startQuestion = Console.ReadLine();
            if (startQuestion == "yes")
            {
                MeatFood meat = new MeatFood();
                CheckFoodStatus(meat);
                Console.WriteLine($"Availability ща {meat.GetType()} in kitchen ?  ");
                meat.CheckAvailability();
            }

            return salats;
        }
    }
}
