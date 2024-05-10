using MenuProject.Models;
using System;
using System.Collections.Generic;

namespace MenuProject.Repos
{
    public class SchoolClassRepo
    {
        #region Database
        List<SchoolClass> schoolClasses = new()
        {
            new SchoolClass()
            {
                Id=Guid.NewGuid(),
                SchoolYear=9,
                ClassType='a',
            },
            new SchoolClass()
            {
                Id=Guid.NewGuid(),
                SchoolYear=9,
                ClassType='b',
            },
            new SchoolClass()
            {
                Id=Guid.NewGuid(),
                SchoolYear=10,
                ClassType='b',
            }
        };    
        #endregion

        public List<SchoolClass> FindAll()
        {
            return schoolClasses;
        }
    }
}
