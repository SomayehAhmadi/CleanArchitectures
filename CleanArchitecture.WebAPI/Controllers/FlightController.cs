using CleanArchitecture.Application.Features.AirportFeatures.GetAllFlightInfo;
using CleanArchitecture.Application.Features.AirportFeatures.GetFlight;
using CleanArchitecture.Application.Features.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("Flight")]
    public class FlightController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FlightController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("FlightByAirportId")]
        public async Task<ActionResult<List<GetAllFlightViewModel>>> GetAllByAirportId([FromQuery] GetAllFlightQuery getAllFlight)
        {
            var response = await _mediator.Send(getAllFlight);
            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult<List<GetAllFlightViewModel>>> Get([FromQuery] GetAllFlightInfoQuery getAllFlightInfo)
        {
            var response = await _mediator.Send(getAllFlightInfo);
            return Ok(response);
        }
    }
}
