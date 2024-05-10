using Kreta.Desktop.Repos;
using Kreta.Desktop.Models.Scholarship;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class AwardedStudentServiceTestsGetNumberOfAwardedStudent
    {
        private readonly AwardedStudentService _awardedStudentService;
        private readonly Mock<IAwardedStudentRepo> _awardedStudentRepoMock = new Mock<IAwardedStudentRepo>();

        public AwardedStudentServiceTestsGetNumberOfAwardedStudent()
        {
            _awardedStudentService = new AwardedStudentService(_awardedStudentRepoMock.Object);
        }

        [TestMethod()]
        public void GetNumberOfAwardedStudentEmptyListTest()
        {
            // arrange
            _awardedStudentRepoMock
                .Setup(mock => mock.FindAll())
                .Returns(Enumerable.Empty<AwardedStudent>().ToList());
            // act

            // assert
        }


        [TestMethod()]
        public void GetNumberOfAwardedStudentDifferentStudentsListTest()
        {
            // arrange
            List<AwardedStudent> awardedStudents = new List<AwardedStudent>
            {
                new AwardedStudent
                {
                    StudentId=Guid.NewGuid(),
                },
                new AwardedStudent
                {
                    StudentId=Guid.NewGuid(),
                },
                new AwardedStudent
                {
                    StudentId=Guid.NewGuid(),
                },
            };
            _awardedStudentRepoMock
                .Setup(mock => mock.FindAll())
                .Returns(awardedStudents);
            // act

            // assert

        }

        [TestMethod()]
        public void GetNumberOfAwardedStudentMoreStudentReciveSeveralScholarshupListTest()
        {
            // arange
            Guid studentId1 = Guid.NewGuid();
            Guid studentId2 = Guid.NewGuid();
            Guid studentId3 = Guid.NewGuid();
            
            // act

            // assert
        }
    }
}