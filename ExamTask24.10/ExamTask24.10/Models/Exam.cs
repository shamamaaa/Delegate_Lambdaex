using System;
namespace ExamTask24._10.Models
{
	public class Exam
	{
        public string Subject { get; set; }
        public byte ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get { return StartDate.AddHours(ExamDuration); } }

    }
}

