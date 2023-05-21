using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using Moq;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class FamilyTest
    {
        public Mock<IFamilyRepository> mock = new Mock<IFamilyRepository>();

        [Fact]
        public void GetFamilybyId()
        {
            var model = new Family()
            {
                Id = 1,
               
            };
            mock.Setup(p => p.GetById(2, new System.Threading.CancellationToken())).ReturnsAsync(new Family());
            
            Assert.Equal(model,new Family());
        }
    }
}
