using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.FamilyFeatures.CreateFamily
{
    public class CreateFamilyHandler : IRequestHandler<CreateFamilyRequest, CreateFamilyResponse>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IFamilyRepository _FamilyRepository;
        readonly IMapper _mapper;

        public CreateFamilyHandler(IUnitOfWork unitOfWork, IFamilyRepository FamilyRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _FamilyRepository = FamilyRepository;
            _mapper = mapper;
        }

        public async Task<CreateFamilyResponse> Handle(CreateFamilyRequest request, CancellationToken cancellationToken)
        {
            var FamilyInfo = _mapper.Map<Family>(request);
            _FamilyRepository.Create(FamilyInfo);
            
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateFamilyResponse>(FamilyInfo);
        }
    }
}
