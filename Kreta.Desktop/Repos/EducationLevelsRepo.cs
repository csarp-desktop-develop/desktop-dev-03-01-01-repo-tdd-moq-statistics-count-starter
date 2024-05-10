using Kreta.Desktop.Models;
using Kreta.Desktop.Repos;
using Kreta.Desktop.Database;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class EducationLevelsRepo : IEducationLevelRepo
    {
        public List<EducationLevel> FindAll()
        {
            return KretaDatabase.EducationLevels;
        }
    }
}
