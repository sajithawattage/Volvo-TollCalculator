using Volvo.TollCalculator.Core.Common;

namespace Volvo.TollCalculator.Core.Entities
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
