using System;

namespace Kreta.Desktop.Models
{
    public class TypeOfEducation
    {
        public Guid Id { get; set; }

        public bool HasId => Id != Guid.Empty;

        public string EducationName { get; set; } = string.Empty;
    }
}
