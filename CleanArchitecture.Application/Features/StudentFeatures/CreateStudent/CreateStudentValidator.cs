using FluentValidation;

namespace CleanArchitecture.Application.Features.StudentFeatures.CreateStudent;

public sealed class CreateStudentValidator : AbstractValidator<CreateStudentRequest>
{
    public CreateStudentValidator()
    {
        //RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50).EmailAddress();
        //RuleFor(x => x.LastName).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}