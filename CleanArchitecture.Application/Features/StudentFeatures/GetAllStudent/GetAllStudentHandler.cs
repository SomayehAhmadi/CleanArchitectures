using AutoMapper;
using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.StudentFeatures.GetAllStudent;

public sealed class GetAllStudentHandler : IRequestHandler<GetAllStudentRequest, List<GetAllStudentResponse>>
{
    private readonly IStudentRepository _StudentRepository;
    private readonly IMapper _mapper;

    public GetAllStudentHandler(IStudentRepository StudentRepository, IMapper mapper)
    {
        _StudentRepository = StudentRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllStudentResponse>> Handle(GetAllStudentRequest request, CancellationToken cancellationToken)
    {
        var Students = await _StudentRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllStudentResponse>>(Students);
    }
}