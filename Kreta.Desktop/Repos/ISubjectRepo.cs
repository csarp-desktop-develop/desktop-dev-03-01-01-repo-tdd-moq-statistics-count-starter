using Kreta.Desktop.Models;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface ISubjectRepo
    {
        public List<Subject> FindAll();
    }
}
