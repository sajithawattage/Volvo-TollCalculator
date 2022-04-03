using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo.TollCalculator.API.Models
{
    public class TollCalculateRequestModel
    {
        public string Vehicle { get; set; }
        public DateTime[] TollDates { get; set; }
    }
}
