using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface ITypeOfEducationRepo
    {
        public List<TypeOfEducation> FindAll();
    }
}
