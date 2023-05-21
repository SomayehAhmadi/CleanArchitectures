using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.StudentFeatures.CreateStudent;

public sealed class CreateStudentHandler : IRequestHandler<CreateStudentRequest, CreateStudentResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStudentRepository _StudentRepository;
    private readonly IFamilyRepository _FamiyRepository;
    private readonly IMapper _mapper;

    public CreateStudentHandler(IUnitOfWork unitOfWork, IStudentRepository StudentRepository, IFamilyRepository familyRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _StudentRepository = StudentRepository;
        _FamiyRepository = familyRepository;
        _mapper = mapper;
    }

    public async Task<CreateStudentResponse> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
    {
        //var familyInfo = _FamiyRepository.GetById(request.FamilyId, cancellationToken);
        long IsOk = 0;
        request.Students.ForEach(r =>
        {

            var StudentInfo = _mapper.Map<Student>(r);
            //r.StudentContactInfo.FamilyId = r.FamilyId;
            _StudentRepository.Create(StudentInfo);
            IsOk = 1;
        });

        //request.StudentContactInfo.StudentId = StudentInfo.Id;
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateStudentResponse>(IsOk);
    }
}