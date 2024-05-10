using Kreta.Desktop.Models;
using System.Collections.Generic;


namespace Kreta.Desktop.Repos
{
    public interface IEducationLevelRepo
    {
        public List<EducationLevel> FindAll();
    }
}
