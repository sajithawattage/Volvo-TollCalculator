﻿namespace Volvo.TollCalculator.Models
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
