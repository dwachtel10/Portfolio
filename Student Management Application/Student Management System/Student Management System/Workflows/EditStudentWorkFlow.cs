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
    public class EditStudentWorkFlow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Edit Student GPA");


            StudentRepository repo = new StudentRepository(Settings.FilePath);
            List<Student> students = repo.List();

            ConsoleIO.PrintPickListOfStudents(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student would you like to edit?", students.Count());
            index--;

            Console.WriteLine();
            

            students[index].GPA = ConsoleIO.GetRequiredDecimalFromUser(string.Format($"Enter the new GPA for {students[index].FirstName} {students[index].LastName}."));

            repo.Edit(students[index], index);

            Console.WriteLine("GPA updated.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
