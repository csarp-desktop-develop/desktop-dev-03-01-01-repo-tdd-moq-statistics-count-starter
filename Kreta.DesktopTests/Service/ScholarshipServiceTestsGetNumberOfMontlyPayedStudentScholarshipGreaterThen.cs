using Kreta.Desktop.Repos;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class ScholarshipServiceTestsGetNumberOfMontlyPayedStudentScholarshipGreaterThen
    {
        private readonly ScholarshipService _scholarshipService;
        private readonly Mock<IAwardedStudentRepo> _awardedStudentRepo = new Mock<IAwardedStudentRepo>();

        public ScholarshipServiceTestsGetNumberOfMontlyPayedStudentScholarshipGreaterThen()
        {
            
        }

        [TestMethod()]
        public void GetNumberOfMontlyPayedStudentScholarshipGreaterThenTest()
        {
            Assert.Fail();
        }
    }
}