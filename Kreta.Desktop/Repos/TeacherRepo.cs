using System.Collections.Generic;
using Kreta.Desktop.SchoolCitizens;
using Kreta.Desktop.Database;

namespace Kreta.Desktop.Repos
{
    public class TeacherRepo
    {
        public List<Teacher> FindAll()
        {
            return KretaDatabase.Teachers;
        }
    }
}
