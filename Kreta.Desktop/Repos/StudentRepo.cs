using Kreta.Desktop.Database;
using Kreta.Desktop.SchoolCitizens;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class StudentRepo : IStudentRepo
    {
        public List<Student> FindAll()
        {
            return KretaDatabase.Students;
        }        
    }
}
