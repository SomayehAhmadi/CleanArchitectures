using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.EnumType;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class StudentDto
    {
        public StudentDto(string firstName, string lastName, GenderType gender, DateTime dateOfBirth, string gradeLevel, long familyId)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GradeLevel = gradeLevel;
            FamilyId = familyId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GradeLevel { get; set; }
        public long FamilyId { get; set; }
    }
    public class StudentTest
    {

        private readonly Mock<IStudentRepository> studentRepo;
        private readonly IStudentRepository studentService;
        public StudentTest()
        {
            studentRepo = new Mock<IStudentRepository>();
         }

     
        private static StudentDto GetDto()
        {
            string FirstName = "Sam";
            string LastName = "Sami";
            DateTime DateOfBirth = DateTime.Now;
            GenderType Gender = Domain.Entities.EnumType.GenderType.Man;
            long FamilyId = 16;
             string GradeLevel = "B";
            return new StudentDto(FirstName,LastName,Gender,DateOfBirth,GradeLevel, FamilyId);
        }
        [Fact]
        public async Task GetStudentList_StudentListAsync()
        {
            var r = GetDto();
            //studentService.Create(new Student()
            //{
            //    FirstName = "Sam",
            //    LastName = "Sami",
            //    DateOfBirth = DateTime.Now,
            //    Gender = Domain.Entities.EnumType.GenderType.Man,
            //    FamilyId = 16,
            //    GradeLevel = "B",
            //});
            studentRepo.Setup(repo => repo.Create(It.IsAny<Student>()));

            //Mock.Get(studentRepo)
               studentRepo .Verify(x => x.Create(It.Is<Student>(y
                => y.FirstName== r.FirstName &&
                   y.LastName == r.LastName &&
                   y.DateOfBirth == r.DateOfBirth &&
                   y.Gender == r.Gender &&
                   y.FamilyId == r.FamilyId)))
                ;
        }
    }
}
