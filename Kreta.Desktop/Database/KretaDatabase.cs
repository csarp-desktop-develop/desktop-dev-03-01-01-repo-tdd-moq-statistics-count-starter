using MenuProject.SchoolCitizens;
using System.Collections.Generic;
using System;
using MenuProject.Models.Scholarship;

namespace Kreta.Desktop.Database
{
    public static class KretaDatabase
    {

        #region Ids
        public static Guid award1Id = Guid.NewGuid();
        public static Guid award2Id = Guid.NewGuid();
        public static Guid award3Id = Guid.NewGuid();

        public static Guid student1Id = Guid.NewGuid();
        public static Guid student2Id = Guid.NewGuid();
        public static Guid student3Id = Guid.NewGuid();
        public static Guid student4Id = Guid.NewGuid();
        public static Guid student5Id = Guid.NewGuid();
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
                    Id=Guid.NewGuid(),
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
                    Id=Guid.NewGuid(),
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
                    Id=Guid.NewGuid(),
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
                    Id=Guid.NewGuid(),
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
                    Id=Guid.NewGuid(),
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
    }
}
