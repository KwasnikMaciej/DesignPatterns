using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.SetDescription("Espresso");
        }

        public override decimal GetCost()
        {
            return 1.99M;
        }
    }
}
