using Kreta.Desktop.Database;
using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class TypeOfEducationRepo : ITypeOfEducationRepo
    {
        public List<TypeOfEducation> FindAll()
        {
            return KretaDatabase.typeOfEducations;
        }
    }
}
