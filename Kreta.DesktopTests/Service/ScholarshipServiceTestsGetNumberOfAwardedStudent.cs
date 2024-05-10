using Moq;
using Kreta.Desktop.Repos;
using MenuProject.Models.Scholarship;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class ScholarshipServiceTestsGetNumberOfAwardedStudent
    {

        private readonly ScholarshipService _scholarshipService;
        private readonly Mock<IAwardedStudentRepo> _awardedStudentRepo= new Mock<IAwardedStudentRepo>();

        public ScholarshipServiceTestsGetNumberOfAwardedStudent()
        {
            _scholarshipService = new ScholarshipService(_awardedStudentRepo.Object);
        }

        [TestMethod()]
        public void GetNumberOfAwardedStudentEmptyListTest()
        {
            _awardedStudentRepo
                .Setup(mock => mock.FindAll())
                .Returns(Enumerable.Empty<AwardedStudent>().ToList());

            int actual = _scholarshipService.GetNumberOfAwardedStudent();
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetNumberOfAwardedStudentDifferentStudentsListTest()
        {
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


            _awardedStudentRepo
                .Setup(mock => mock.FindAll())
                .Returns(awardedStudents);

            int actual = _scholarshipService.GetNumberOfAwardedStudent();
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetNumberOfAwardedStudentMoreStudentReciveSeveralScholarshupListTest()
        {
            Guid studentId1 = Guid.NewGuid();
            Guid studentId2 = Guid.NewGuid();
            Guid studentId3 = Guid.NewGuid();

            List<AwardedStudent> awardedStudents = new List<AwardedStudent>
            {
                new AwardedStudent
                {
                    StudentId=studentId1,
                },
                new AwardedStudent
                {
                    StudentId=studentId2,
                },
                new AwardedStudent
                {
                    StudentId=studentId3,
                },
                new AwardedStudent
                {
                    StudentId=studentId1,
                },
                new AwardedStudent
                {
                    StudentId=studentId3,
                },
                new AwardedStudent
                {
                    StudentId=studentId3,
                },

            };


            _awardedStudentRepo
                .Setup(mock => mock.FindAll())
                .Returns(awardedStudents);

            int actual = _scholarshipService.GetNumberOfAwardedStudent();
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }


    }
}