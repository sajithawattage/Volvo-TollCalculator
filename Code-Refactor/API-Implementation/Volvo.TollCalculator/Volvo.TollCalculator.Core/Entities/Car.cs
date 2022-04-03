using Volvo.TollCalculator.Core.Common;

namespace Volvo.TollCalculator.Core.Entities
{
    public class Car : Vehicle
    {
        public override bool VehicleTollFree { get { return false; } }
    }
}
