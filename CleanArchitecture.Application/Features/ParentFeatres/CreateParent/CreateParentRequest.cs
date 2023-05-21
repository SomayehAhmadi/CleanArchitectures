using CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily;
using MediatR;

namespace CleanArchitecture.Application.Features.ParentFeatres.CreateParent
{
    public class CreateParentRequest : IRequest<CreateParentResponse>
    {
        public List<ParentRequest> Parents { get; set; }

    }
}
