using CleanArchitecture.Application.Features.AirportFeatures.GetAirport;
using CleanArchitecture.Application.Features.AirportFeatures.GetFlight;
using CleanArchitecture.Application.Features.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("Airport")]

    public class AirportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AirportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllAirportViewModel>>> Get([FromQuery] GetAllAirportQuery getAllAirport, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(getAllAirport);
            return Ok(response);
        }
    }


}
