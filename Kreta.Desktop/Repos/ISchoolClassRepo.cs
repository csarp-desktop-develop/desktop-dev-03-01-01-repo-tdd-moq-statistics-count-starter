using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface ISchoolClassRepo
    {
        public List<SchoolClass> FindAll();
    }
}
