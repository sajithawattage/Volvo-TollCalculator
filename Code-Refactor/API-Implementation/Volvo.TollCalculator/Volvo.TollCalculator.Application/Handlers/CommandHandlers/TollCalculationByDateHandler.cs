using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volvo.TollCalculator.Application.Commands;
using Volvo.TollCalculator.Application.Extenstions;
using Volvo.TollCalculator.Application.Response;

namespace Volvo.TollCalculator.Application.Handlers.CommandHandlers
{
    public class TollCalculationByDateHandler : IRequestHandler<TollCalculationByDateCommand, TollCalcultionResponse>
    {
        public Task<TollCalcultionResponse> Handle(TollCalculationByDateCommand request, CancellationToken cancellationToken = default)
        {
            CalculationBehaviour calculationBehaviour = new CalculationBehaviour();

            var tollAmount = calculationBehaviour.GetTollFeeByDate(request.TollDate, request.Vehicle);

            var response = new TollCalcultionResponse()
            {
                TollAmount = tollAmount
            };

            return Task.FromResult(response);
        }
    }
}
