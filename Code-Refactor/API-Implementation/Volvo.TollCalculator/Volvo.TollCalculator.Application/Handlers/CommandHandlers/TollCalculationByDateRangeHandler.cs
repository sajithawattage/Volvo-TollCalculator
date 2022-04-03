using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Volvo.TollCalculator.Application.Commands;
using Volvo.TollCalculator.Application.Extenstions;
using Volvo.TollCalculator.Application.Response;

namespace Volvo.TollCalculator.Application.Handlers.CommandHandlers
{
    public class TollCalculationByDateRangeHandler : IRequestHandler<TollCalculationByDateRangeCommand, TollCalcultionResponse>
    {
        public Task<TollCalcultionResponse> Handle(TollCalculationByDateRangeCommand request, CancellationToken cancellationToken = default)
        {
            CalculationBehaviour calculationBehaviour = new CalculationBehaviour();

            var tollAmount = calculationBehaviour.GetTollFee(request.Vehicle, request.TollDate);

            var response = new TollCalcultionResponse()
            {
                TollAmount = tollAmount
            };

            return Task.FromResult(response);
        }
    }
}
