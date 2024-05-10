using Kreta.Desktop.Models.Scholarship;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface IAwardedStudentRepo
    {
        public List<AwardedStudent> FindAll();
    }
}
