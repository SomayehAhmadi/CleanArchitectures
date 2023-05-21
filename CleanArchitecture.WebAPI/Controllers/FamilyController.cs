using CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily;
using CleanArchitecture.Application.Features.FamilyFeatures.GetFamily;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("Family")]

    public class FamilyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FamilyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<GetAllFamilyResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllFamilyRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateFamilyResponse>> Create(CreateFamilyRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
