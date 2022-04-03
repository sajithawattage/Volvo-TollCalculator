using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo.TollCalculator.Models
{
    public class Foreign : Vehicle
    {
        public override bool VehicleTollFree
        {
            get
            {
                return true;
            }
        }
    }
}
