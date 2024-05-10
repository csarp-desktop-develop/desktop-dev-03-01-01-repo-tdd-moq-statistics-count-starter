using Kreta.Desktop.Repos;

namespace Kreta.Desktop.Service
{
    public class ScholarshipService : IScholarshipService
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IAwardedStudentRepo _awardedStudentRepo;

        public ScholarshipService(IStudentRepo studentRepo, IAwardedStudentRepo awardedStudentRepo) 
        {
            _studentRepo = studentRepo;
            _awardedStudentRepo = awardedStudentRepo;
        }
    }
}
