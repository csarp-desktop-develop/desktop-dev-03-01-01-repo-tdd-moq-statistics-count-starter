using System;

namespace Kreta.Desktop.Models
{
    public class SubjectType
    {
        public SubjectType()
        {
            Id = Guid.Empty;
            SubjectTypeName = string.Empty;
        }
        public SubjectType(Guid id, string subjectTypeName)
        {
            Id = id;
            SubjectTypeName = subjectTypeName;
        }

        public Guid Id { get; set; }
        public string SubjectTypeName { get; set; }
        public bool HasId => Id != Guid.Empty;
    }
}
