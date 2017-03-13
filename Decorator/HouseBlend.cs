using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.SetDescription("House Blend Coffee");
        }

        public override decimal GetCost()
        {
            return 0.89M;
        }
    }
}
