using MediatR;

namespace CleanArchitecture.Application.Features.ParentFeatres.GetParent
{
    public sealed record GetAllParentRequest : IRequest<List<GetAllParentResponse>>;
}
