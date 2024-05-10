using System.Collections.Generic;
using MenuProject.SchoolCitizens;
using Kreta.Desktop.Database;

namespace MenuProject.Repos
{
    public class TeacherRepo
    {
        public List<Teacher> FindAll()
        {
            return KretaDatabase.Teachers;
        }
    }
}
