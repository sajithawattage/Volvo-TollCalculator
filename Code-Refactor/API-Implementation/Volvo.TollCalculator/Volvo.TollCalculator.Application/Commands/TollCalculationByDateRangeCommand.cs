using MediatR;
using System;
using Volvo.TollCalculator.Application.Response;
using Volvo.TollCalculator.Core.Common;

namespace Volvo.TollCalculator.Application.Commands
{
    public class TollCalculationByDateRangeCommand : IRequest<TollCalcultionResponse>
    {
        public Vehicle Vehicle { get; set; }
        public DateTime[] TollDate { get; set; }
    }
}
