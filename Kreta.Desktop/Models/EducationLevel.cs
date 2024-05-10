using System;

namespace Kreta.Desktop.Models
{
    public class EducationLevel
    {
        public EducationLevel()
        {
            Id=Guid.Empty;
            EducationLevelName = string.Empty;
        }
        public EducationLevel(Guid id, string educationLevelName)
        {
            Id = id;
            EducationLevelName = educationLevelName;
        }

        public Guid Id { get; set; }
        public string EducationLevelName { get; set; }
    }
}
