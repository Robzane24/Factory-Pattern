using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            if (wheelCount == 4)
            {
                return new Car();
            }
            else if (wheelCount == 2)
            {
                return new Motorcycle();
            }
            return null;
            
                       
        }
    }
}
