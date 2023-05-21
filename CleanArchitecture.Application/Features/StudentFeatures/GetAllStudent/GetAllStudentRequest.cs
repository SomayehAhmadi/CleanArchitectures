using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using MediatR;

namespace CleanArchitecture.Application.Features.StudentFeatures.GetAllStudent;

public sealed record GetAllStudentRequest : IRequest<List<GetAllStudentResponse>>;