using Kreta.Desktop.SchoolCitizens;
using System.Collections.Generic;
using System;
using Kreta.Desktop.Models.Scholarship;
using Kreta.Desktop.Models;


namespace Kreta.Desktop.Database
{
    public static class KretaDatabase
    {

        #region Ids
        public static Guid educationLevelId1 = Guid.NewGuid();
        public static Guid educationLevelId2 = Guid.NewGuid();
        public static Guid educationLevelId3 = Guid.NewGuid();

        public static Guid award1Id = Guid.NewGuid();
        public static Guid award2Id = Guid.NewGuid();
        public static Guid award3Id = Guid.NewGuid();

        public static Guid student1Id = Guid.NewGuid();
        public static Guid student2Id = Guid.NewGuid();
        public static Guid student3Id = Guid.NewGuid();
        public static Guid student4Id = Guid.NewGuid();
        public static Guid student5Id = Guid.NewGuid();

        public static Guid parentId1 = Guid.NewGuid();
        public static Guid parentId2 = Guid.NewGuid();
        public static Guid parentId3 = Guid.NewGuid();
        public static Guid parentId4 = Guid.NewGuid();
        public static Guid parentId5 = Guid.NewGuid();
        public static Guid parentId6 = Guid.NewGuid();

        public static Guid subjectId1 = Guid.NewGuid();
        public static Guid subjectId2 = Guid.NewGuid();
        public static Guid subjectId3 = Guid.NewGuid();

        public static Guid typeOfSubject1 = Guid.NewGuid();
        public static Guid typeOfSubject2 = Guid.NewGuid();
        public static Guid typeOfSubject3 = Guid.NewGuid();


        private static Guid schoolClassId1 = Guid.NewGuid();
        private static Guid schoolClassId2 = Guid.NewGuid();
        private static Guid schoolClassId3 = Guid.NewGuid();

        private static Guid typeOfEducation1 = Guid.NewGuid();
        private static Guid typeOfEducation2 = Guid.NewGuid();
        private static Guid typeOfEducation3 = Guid.NewGuid();

        private static Guid teacherId1 = Guid.NewGuid();
        private static Guid teacherId2 = Guid.NewGuid();
        private static Guid teacherId3 = Guid.NewGuid();
        private static Guid teacherId4 = Guid.NewGuid();
        private static Guid teacherId5 = Guid.NewGuid();
        #endregion

        public static List<TypeOfEducation> typeOfEducations = new()
        #region TypeOfEdicationsDatabase
        {
            new TypeOfEducation
            {
                Id = typeOfEducation1,
                EducationName="Szoftverfejlesztő és -tesztelő"
            },
            new TypeOfEducation
            {
                Id = typeOfEducation2,
                EducationName="Idegen nyelvű ipari és kereskedelmi technikus"
            },
            new TypeOfEducation
            {
                Id = typeOfEducation3,
                EducationName="Vállalkozási ügyviteli ügyintéző"
            }
        };
        #endregion
        public static List<Student> Students = new()
        #region Database
        {
            new() {
                Id=student1Id,
                FirstName="János",
                LastName="Jegy",
                IsWoman=false,
                BirthDay=new DateTime(2021,3,13),
                PlaceOfBirth="Szeged",
                SchoolYear=9,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="szakképzés"
            },
            new() {
                Id=student2Id,
                FirstName="Szonja",
                LastName="Stréber",
                BirthDay=new DateTime(2020,4,24),
                PlaceOfBirth="Makó",
                IsWoman=true,
                SchoolYear=10,
                SchoolClass = SchoolClassType.ClassB,
                EducationLevel="szakképzés"
            },
            new() {
                Id=student3Id,
                FirstName="Ubul",
                LastName="Ugráló",
                PlaceOfBirth="Makó",
                IsWoman=false,
                BirthDay=new DateTime(2020,2,11),
                SchoolYear=10,
                SchoolClass = SchoolClassType.ClassB,
                EducationLevel="érettségi"
            },
            new() {
                Id=student4Id,
                FirstName="Kati",
                LastName="Késő",
                PlaceOfBirth="Domaszék",
                IsWoman=true,
                BirthDay=new DateTime(2019,2,11),
                SchoolYear=12,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="érettségi"
            },
            new() {
                Id=student5Id,
                FirstName="Kenéz",
                LastName="Kísérletező",
                PlaceOfBirth="Budapest",
                IsWoman=false,
                BirthDay=new DateTime(2017,2,11),
                SchoolYear=14,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="szakképzés"
            }
        };
        #endregion

        public static List<Teacher> Teachers = new()
        #region TeacherDatabase
        {
                new Teacher
                {
                    Id=teacherId1,
                    FirstName="Martin",
                    LastName="Magyar",
                    BirthDay=new DateTime(2000,10,10),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Miskolc",
                    IsWoman=false,
                    MathersName="Miskolci Mária"
                },
                new Teacher
                {
                    Id=teacherId2,
                    FirstName="Mirjam",
                    LastName="Metek",
                    BirthDay=new DateTime(2000,11,11),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Eger",
                    IsWoman=true,
                    MathersName="Egri Etelka"

                },
                new Teacher
                {
                    Id=teacherId3,
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthDay=new DateTime(2000,12,12),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Szabadka",
                    IsWoman=false,
                    MathersName="Szabadkai Szabina"

                },
                new Teacher
                {
                    Id=teacherId4,
                    FirstName="Éva",
                    LastName="Ének",
                    BirthDay=new DateTime(2000,1,1),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Baja",
                    IsWoman=true,
                    MathersName="Bajai Betti"
                },
                new Teacher
                {
                    Id=teacherId5,
                    FirstName="Adorján",
                    LastName="Angol",
                    BirthDay=new DateTime(2000,3,3),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Kecskemét",
                    IsWoman=false,
                    MathersName="Kecskeméti Kati"
                }
            };
        #endregion

        public static List<AwardedStudent> AwardedStudents = new()
        #region AwardedStudentDatabase
        {
            new AwardedStudent
            {
                AwardedID=award1Id,
                StudentId=student1Id,
                Award = 60000,
                MonthlyPayment=true,
                PaymentStart=new DateTime(2023,09,01),
                PaymentEnd=new DateTime(2024,08,31),
            },
            new AwardedStudent
            {
                AwardedID=award2Id,
                StudentId=student3Id,
                Award = 70000,
                MonthlyPayment=true,
                PaymentStart=new DateTime(2024,09,01),
                PaymentEnd=new DateTime(2025,08,31),
            },
            new AwardedStudent
            {
                AwardedID=award3Id,
                StudentId=student2Id,
                Award = 30000,
                MonthlyPayment=false,
                PaymentStart=new DateTime(2023,09,01),
                PaymentEnd=new DateTime(2024,08,31),
            },
        };
        #endregion

        public static List<EducationLevel> EducationLevels = new()
        #region EducationLevelsDatabase
        {
            new EducationLevel
            {
                Id=educationLevelId1,
                EducationLevelName="érettségi",
            },
            new EducationLevel
            {
                Id = educationLevelId2,
                EducationLevelName="szakképzés",
            },
            new EducationLevel
            {
                Id=educationLevelId3,
                EducationLevelName="szakmunkás képzés",
            }
        };
        #endregion

        public static List<Parent> Parents = new()
        #region ParentsDatabase
        {
            new Parent
            {
                Id = parentId1,
                FirstName = "Virág",
                LastName = "Vas",
                IsWoman = true,
                BirthDay = new DateTime(1998, 8, 8),
                PlaceOfBirth = "Szeged",
                MathersName = "Érc Kitti",
            },
            new Parent
            {
                Id = parentId2,
                FirstName = "Petra",
                LastName = "Pénzes",
                IsWoman = true,
                BirthDay = new DateTime(1997, 7, 7),
                PlaceOfBirth = "Kistelek",
                MathersName = "Szegény Szandi",

            },
            new Parent
            {
                Id = parentId3,
                FirstName = "Ferenc",
                LastName = "Fukar",
                IsWoman = false,
                BirthDay = new DateTime(1995, 5, 5),
                PlaceOfBirth = "Szeged",
                MathersName = "Adakozó Andor",

            },
            new Parent
            {
                Id = parentId4,
                FirstName = "Fruzsi",
                LastName = "Fukar",
                IsWoman = true,
                BirthDay = new DateTime(1994, 4, 4),
                PlaceOfBirth = "Makó",
                MathersName = "Adó Anna",

            },
            new Parent
            {
                Id = parentId5,
                FirstName = "Hedvig",
                LastName = "Hosszú",
                IsWoman = true,
                BirthDay = new DateTime(1992, 2, 2),
                PlaceOfBirth = "Szeged",
                MathersName = "Alacsony Anikó",

            },
            new Parent
            {
                Id = parentId6,
                FirstName = "Milán",
                LastName = "Magas",
                IsWoman = false,
                BirthDay = new DateTime(1992, 2, 2),
                PlaceOfBirth = "Deszk",
                MathersName = "Alacsony Anikó",

            }
        };
        #endregion
        
        public static List<SubjectType> SubjectTypes = new List<SubjectType>
        #region SubjectTypesDatabase
        {
            new SubjectType
            {
                Id = typeOfSubject1,
                SubjectTypeName="Természettudomány",
            },
            new SubjectType
            {
                Id = typeOfSubject2,
                SubjectTypeName="Idegen nyelv",
            },
            new SubjectType
            {
                Id = typeOfSubject3,
                SubjectTypeName="Közgazdaságtan",
            },
        };
        #endregion

        public static List<Subject> Subjects = new List<Subject>
        #region SubjectsDatabase
        {
            new Subject
            {
                Id=subjectId1,
                SubjectName="Földrajz",
                ShortName="Föci",
                SubjectTypeId=typeOfSubject1,
                CompulsoryExaminationSubject=false,
                OptionalExaminationSubject=true,
            },
            new Subject
            {
                Id=subjectId2,
                SubjectName="Angol",
                ShortName="Angol",
                SubjectTypeId=typeOfSubject2,
                CompulsoryExaminationSubject=true,
                OptionalExaminationSubject=false,
            },
            new Subject
            {
                Id=subjectId3,
                SubjectName="Marketing",
                ShortName="Market",
                SubjectTypeId=typeOfSubject3,
                CompulsoryExaminationSubject=false,
                OptionalExaminationSubject=false,
            }
        };
        #endregion


        public static List<SchoolClass> SchoolClasses = new List<SchoolClass>
        #region SchoolClassesDatabase
        {
            new SchoolClass
            {
                Id=schoolClassId1,
                SchoolYear=9,
                SchoolClassType=SchoolClassType.ClassA,
                YearOfEnrolment=2025,
                IsArchived=false,
                TypeOfEducationId=typeOfEducation1,
                HeadTeacherId=teacherId2,
            },
            new SchoolClass
            {
                Id=schoolClassId2,
                SchoolYear=10,
                SchoolClassType=SchoolClassType.ClassB,
                YearOfEnrolment=2024,
                IsArchived=false,
                TypeOfEducationId=typeOfEducation2,
            },
            new SchoolClass
            {
                Id=schoolClassId3,
                SchoolYear=14,
                SchoolClassType=SchoolClassType.ClassB,
                YearOfEnrolment=2024,
                IsArchived=false,
                TypeOfEducationId=typeOfEducation3,
            },
        };
        #endregion
    }
}
        
        
 
   


