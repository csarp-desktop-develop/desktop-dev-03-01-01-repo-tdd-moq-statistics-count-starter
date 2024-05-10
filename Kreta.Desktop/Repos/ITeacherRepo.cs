using Kreta.Desktop.SchoolCitizens;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface ITeacherRepo
    {
        public List<Teacher> FindAll();
    }
}
