using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo.TollCalculator.Application.Response;
using Volvo.TollCalculator.Core.Common;

namespace Volvo.TollCalculator.Application.Commands
{
    public class TollCalculationByDateCommand : IRequest<TollCalcultionResponse>
    {
        public Vehicle Vehicle { get; set; }
        public DateTime TollDate { get; set; }
    }
}
