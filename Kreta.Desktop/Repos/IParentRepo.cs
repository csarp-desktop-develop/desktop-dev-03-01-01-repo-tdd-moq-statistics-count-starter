using Kreta.Desktop.SchoolCitizens;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface IParentRepo
    {
        public List<Parent> FindAll();
    }
}
