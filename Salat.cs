using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    public abstract class Salat : IComparable, IHaveSeeds, IStatus, IAvailability
    {
        private static int _sumOfInstance = 0;
        public Salat()
        {
            _sumOfInstance++;
        }

        public abstract int Calories { get; }
        public abstract int Price { get; }
        public IStatus Status { get; set; }
        public bool Availability { get => true; }
        public virtual void Opportunities()
        {
            Console.WriteLine("i'm involved in salat  ");
        }

        public void SumOfInstance()
        {
            Console.WriteLine(_sumOfInstance);
        }

        public void SeedsCheck(IHaveSeeds have)
        {
            have.HaveSeeds();
        }

        public int CompareTo(object o)
        {
            Salat p = o as Salat;
            if (p != null)
            {
                return Price.CompareTo(p.Price);
            }
            else
            {
                throw new BusinessException("real error");
            }
        }

        public void HaveSeeds()
        {
            Console.WriteLine("i can include seeds with probability 43%");
        }

        public void CheckAvailability()
        {
            Console.WriteLine(Availability);
        }
    }
}