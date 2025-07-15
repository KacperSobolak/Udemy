using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class BikeStrategy : IRouteStrategy
    {
        public void CreateRoute(Cordinate start, Cordinate end)
        {
            Console.WriteLine("Bike strategy");
        }
    }
}
