using Kreta.Desktop.Repos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kreta.Desktop.Service
{
    public class ScholarshipService
    {
        public IAwardedStudentRepo _awardedStudentRepo;

        public ScholarshipService(IAwardedStudentRepo awardedStudentRepo) 
        {
            _awardedStudentRepo = awardedStudentRepo;
        }

        public int GetNumberOfAwardedStudent()
        {
            List<Guid> awardedStudentsIds = _awardedStudentRepo
                .FindAll()
                .Select(awardedStudent => awardedStudent.StudentId)
                .Distinct()
                .ToList();
            return awardedStudentsIds.Count;
        }

        public int GetNumberOfMontlyPayedStudentScholarshipGreaterThen(int scholarship)
        {
            return 0;
        }

    }
}
