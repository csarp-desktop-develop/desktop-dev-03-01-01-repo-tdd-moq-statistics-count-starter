using MenuProject.Models.Scholarship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Repos
{
    public interface IAwardedStudentRepo
    {
        public List<AwardedStudent> FindAll();
    }
}
