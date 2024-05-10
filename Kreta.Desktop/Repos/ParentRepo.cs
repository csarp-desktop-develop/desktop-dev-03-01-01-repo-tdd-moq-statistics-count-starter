using System.Collections.Generic;
using Kreta.Desktop.SchoolCitizens;
using Kreta.Desktop.Database;

namespace Kreta.Desktop.Repos
{
    public class ParentRepo : IParentRepo
    {
        public List<Parent> FindAll()
        {
            return KretaDatabase.Parents;
        }
    }
}
