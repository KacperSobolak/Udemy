using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Map(IRouteStrategy routeStrategy)
    {
        private readonly IRouteStrategy _routeStrategy = routeStrategy;

        public void CreateRoute(Cordinate start, Cordinate end)
        {
            _routeStrategy.CreateRoute(start, end);
        }
    }
}
