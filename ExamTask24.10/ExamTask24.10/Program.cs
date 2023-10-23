using System;
using ExamTask24._10.Models;

namespace ExamTask24._10;
class Program
{
    static void Main(string[] args)
    {
        List<Exam> exams = new List<Exam>
        {
            new Exam { Subject = "Riyaziyyat", ExamDuration = 2, StartDate = DateTime.Now.AddDays(-3)},
            new Exam { Subject = "Musiqi", ExamDuration = 1, StartDate = DateTime.Now},
            new Exam { Subject = "Kimya", ExamDuration = 3, StartDate = DateTime.Now.AddDays(4)},
            new Exam { Subject = "Fizika", ExamDuration = 4, StartDate = DateTime.Now.AddDays(-8)},

        };

        //-son 1 hefte erzinde olan examlarin siyahisini gosterirsini

        List<Exam> WeekExams = exams.FindAll(e => e.StartDate >= DateTime.Now.AddDays(-7));
        Console.WriteLine("Son 1 hefte erzinde olan examlar:");
        Print(WeekExams);
        Console.ReadLine();

        // - 2 saatdan uzun ceken imtahanlarin siyahisi

        List<Exam> ExamHours = exams.FindAll(e => e.ExamDuration > 2);
        Console.WriteLine("2 saatdan uzun ceken examlar:");
        Print(ExamHours);
        Console.ReadLine();

        //-bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi

        List<Exam> ExamNow = exams.FindAll(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now);
        Console.WriteLine("Hal hazirda davam eden examlar:");
        Print(ExamNow);
        Console.ReadLine();
    }


    static void Print(List<Exam> examList)
    {
        foreach (Exam exam in examList)
        {
            Console.WriteLine($"Ders:{exam.Subject}, Muddet:{exam.ExamDuration} saat");
        }
    }
}

