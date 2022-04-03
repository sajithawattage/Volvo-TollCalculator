using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volvo.TollCalculator.API.Extensions;
using Volvo.TollCalculator.API.Models;
using Volvo.TollCalculator.Application.Commands;
using Volvo.TollCalculator.Application.Response;

namespace Volvo.TollCalculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TollCalculationController : ControllerBase
    {
        private readonly IMediator mediator;

        public TollCalculationController(IMediator _mediator)
        {
            mediator = _mediator;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [HttpPost]
        public async Task<ActionResult<TollCalcultionResponse>> Calculate([FromBody] TollCalculateRequestModel model)
        {
            try
            {
                return await mediator.Send(new TollCalculationByDateRangeCommand
                {
                    Vehicle = VehicleInstanceExtenstion.GetVehicleByName(model.Vehicle),
                    TollDate = model.TollDates
                });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
