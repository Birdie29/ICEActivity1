using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ICEActivity1
{
    internal class Program
    {
        static Student[] students =
            { new Student("Apple", "ST001", 75),
             new Student("Derrick", "ST002", 88),
             new Student("Kelly", "ST003", 98),
             new Student("John", "ST004", 70),
             new Student("Sam", "ST005", 100)
        };

        static void DisplayStudentInformation() 
        {
            Console.WriteLine("Studnet Information Thread Started...");
            for(int i=0; i<students.Length; i++)
            {
                Console.WriteLine("Student:" + students[i].studentName);
                Console.WriteLine("Student Number:" + students[i].studentNumber);
                Console.WriteLine("Marks:" + students[i].marks);
                Console.WriteLine();

            }
            Console.WriteLine("Student Information Thread Completed.");
        }

        static void CalculateAverage()
        {
            Console.WriteLine("Calculating Average Thred Started...");
            double total = 0;
            for (int i = 0; i < students.Length; i++)
            {
                total = total + students[i].marks;
            }
            double average = total / students.Length;
            Console.WriteLine("Average Mark:" + average);
            Console.WriteLine("Calculating Average Thread Completed.");

        }

        static void generateReport()
        {
            Console.WriteLine("Report Thread Started...");
            for (int i = 0; i < students.Length; i++) 
            {
                Console.WriteLine(students[i].studentName + "-" + students[i].marks);
            }
            Console.WriteLine("Report Generation Complete.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Multithread Student Task Manager");
            Console.WriteLine();

            Thread studentThread = new Thread(DisplayStudentInformation);
            Thread averageThread = new Thread(CalculateAverage);
            Thread reportThread = new Thread(generateReport);

            studentThread.Start();
            averageThread.Start();
            reportThread.Start();

            studentThread.Join();
            averageThread.Join();
            reportThread.Join();

            Console.WriteLine();
            Console.WriteLine("All tasks completed.");
        }
        

    }
}
