using MenuProject.Models;
using System;
using System.Collections.Generic;

namespace MenuProject.Repos
{
    class SubjectRepo
    {
        private List<Subject> subjects = new()
        {
            new Subject
            {
                ID=Guid.NewGuid(),
                SubjectName="Történelem"
            },
            new Subject
            {
                ID=Guid.NewGuid(),
                SubjectName="Földrajz"
            }
        };

        public List<Subject> FindAll()
        {
            return subjects;
        }
    }
}
