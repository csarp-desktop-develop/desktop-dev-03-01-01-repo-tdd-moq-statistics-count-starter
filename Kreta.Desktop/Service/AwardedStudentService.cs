using Kreta.Desktop.Repos;

namespace Kreta.Desktop.Service
{
    public class AwardedStudentService : IAwardedStudentService
    {
        private readonly IAwardedStudentRepo _awardedStudentRepo;

        public AwardedStudentService(IAwardedStudentRepo awardedStudentRepo)
        {
            _awardedStudentRepo = awardedStudentRepo;
        }

        public int GetNumberOfAwardedStudent()
        {
            return 0;
        }
    }
}
