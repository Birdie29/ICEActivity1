using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEActivity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                studentName = "Apple",
                studentNumber = "ST001",
                marks = 75
            };

            Student student2 = new Student
            { 
                studentName = "Damien",
                studentNumber = "ST002",
                marks = 88
            };

            Student student3 = new Student
            {
                studentName = "Charlie",
                studentNumber = "ST003",
                marks = 98
            };

            Student student4 = new Student
            {
                studentName = "Ace",
                studentNumber = "ST004",
                marks = 92
            };

            Student student5 = new Student
            {
                studentName = "Ollie",
                studentNumber = "ST005",
                marks = 70
            };
               
        }
    }
}
