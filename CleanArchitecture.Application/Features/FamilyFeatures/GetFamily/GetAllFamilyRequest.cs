using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.FamilyFeatures.GetFamily
{

    public sealed class GetAllFamilyHandler : IRequestHandler<GetAllFamilyRequest, List<GetAllFamilyResponse>>
    {
        private readonly IFamilyRepository _FamilyRepository;
        private readonly IMapper _mapper;

        public GetAllFamilyHandler(IFamilyRepository FamilyRepository, IMapper mapper)
        {
            _FamilyRepository = FamilyRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllFamilyResponse>> Handle(GetAllFamilyRequest request, CancellationToken cancellationToken)
        {
            var Familys = await _FamilyRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllFamilyResponse>>(Familys);
        }
    }
    public class GetAllFamilyRequest : IRequest<List<GetAllFamilyResponse>>
    {
    }  
    public class GetAllFamilyResponse
    {
    }
}
