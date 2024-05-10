using Kreta.Desktop.Database;
using MenuProject.Models.Scholarship;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class AwardedStudentRepo : IAwardedStudentRepo
    {
        public List<AwardedStudent> FindAll()
        {
            return KretaDatabase.AwardedStudents;
        }
    }
}
