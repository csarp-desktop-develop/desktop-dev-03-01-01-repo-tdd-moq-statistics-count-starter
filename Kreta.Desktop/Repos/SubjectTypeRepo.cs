using Kreta.Desktop.Database;
using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class SubjectTypeRepo : ISubjectTypeRepo
    {
        public List<SubjectType> FindAll()
        {
            return KretaDatabase.SubjectTypes;
        }
    }
}
