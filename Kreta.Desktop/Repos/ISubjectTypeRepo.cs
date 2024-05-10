using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface ISubjectTypeRepo
    {
        public List<SubjectType> FindAll();
    }
}
