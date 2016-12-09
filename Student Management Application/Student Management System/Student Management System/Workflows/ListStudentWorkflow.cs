using Student_Management_System.Data;
using Student_Management_System.Helpers;
using Student_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Workflows
{
    public class ListStudentWorkflow
    {
        public void Execute()
        {
            StudentRepository repo = new StudentRepository(Settings.FilePath);
            List<Student> students = repo.List();

            Console.Clear();
            Console.WriteLine("Student List");
            Console.WriteLine(ConsoleIO.SeparatorBar);

            string line = "{0, -15} {1, -15} {2, 5}";
            Console.WriteLine(line, "Name", "Major", "GPA");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            foreach(var student in students)
            {
                Console.WriteLine(line, student.LastName + ", " + student.FirstName, student.Major, student.GPA);
            }
            Console.WriteLine();
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
