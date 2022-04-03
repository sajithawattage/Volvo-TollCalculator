using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo.TollCalculator.Core.Common
{
    public abstract class Vehicle
    {
        public abstract bool VehicleTollFree { get; }
    }
}
