using Kreta.Desktop.Database;
using MenuProject.SchoolCitizens;
using System.Collections.Generic;

namespace MenuProject.Repos
{
    public class StudentRepo
    {
        public List<Student> FindAll()
        {
            return KretaDatabase.Students;
        }        
    }
}
