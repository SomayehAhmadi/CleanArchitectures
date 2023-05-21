using AutoMapper;
using CleanArchitecture.Application.Features.ParentFeatres.CreateParent;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;
 

public sealed partial class CreateParentHandler : IRequestHandler<CreateParentRequest, CreateParentResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IParentRepository _ParentRepository;
    private readonly IMapper _mapper;

    public CreateParentHandler(IUnitOfWork unitOfWork, IParentRepository ParentRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _ParentRepository = ParentRepository;
        _mapper = mapper;
    }

    public async Task<CreateParentResponse> Handle(CreateParentRequest request, CancellationToken cancellationToken)
    {
        bool IsOk = false;
        request.Parents.ForEach(r =>
        {

            var ParentInfo = _mapper.Map<Parent>(r);
            _ParentRepository.Create(ParentInfo);
            IsOk = true;
        });

        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateParentResponse>(IsOk);
    }
}