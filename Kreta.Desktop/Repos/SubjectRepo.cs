using Kreta.Desktop.Database;
using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    class SubjectRepo : ISubjectRepo
    {
        public List<Subject> FindAll()
        {
            return KretaDatabase.Subjects;
        }
    }
}
