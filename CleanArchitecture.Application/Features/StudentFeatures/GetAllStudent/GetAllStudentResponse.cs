namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllStudentResponse
{
    public long Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string  Gender { get; set; }
    public string DateOfBirth { get; set; }
    public string GradeLevel { get; set; }

}