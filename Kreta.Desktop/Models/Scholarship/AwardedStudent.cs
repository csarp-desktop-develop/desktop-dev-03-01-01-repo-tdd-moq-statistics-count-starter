using System;

namespace Kreta.Desktop.Models.Scholarship
{
    public class AwardedStudent
    {
        public AwardedStudent(Guid studentId,int award, bool monthlyPayment)
        {
            StudentId = studentId;
            Award = award;
            MonthlyPayment = monthlyPayment;
        }

        public AwardedStudent()
        {
            StudentId = Guid.Empty;
            Award = -1;
            MonthlyPayment = false; ;
        }

        public Guid AwardedID { get; set; }
        public Guid StudentId { get; set; }
        public int Award { get; set; }
        public bool MonthlyPayment { get; set; }        
        public DateTime PaymentStart { get; set; }
        public DateTime? PaymentEnd { get; set; }

        public int Age => -1;
        public bool IsAdult => false;

        public override string ToString()
        {
            return "";
        }

    }
}
