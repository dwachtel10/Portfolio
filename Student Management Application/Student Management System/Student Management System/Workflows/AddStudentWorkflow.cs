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
    public class AddStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Add Student");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine();

            Student newStudent = new Student();

            newStudent.FirstName = ConsoleIO.GetRequiredStringFromUser("First Name: ");
            newStudent.LastName = ConsoleIO.GetRequiredStringFromUser("Last Name: ");
            newStudent.Major = ConsoleIO.GetRequiredStringFromUser("Major: ");
            newStudent.GPA = ConsoleIO.GetRequiredDecimalFromUser("GPA: ");

            Console.WriteLine();
            ConsoleIO.PrintStudentListHeader();
            Console.WriteLine(ConsoleIO.StudentLineFormat, newStudent.LastName + ", " + newStudent.FirstName, newStudent.Major, newStudent.GPA);

            Console.WriteLine();
            if(ConsoleIO.GetYesNoAnswerFromuser("Add the following information?") == "Y")
            {
                StudentRepository repo = new StudentRepository(Settings.FilePath);
                repo.Add(newStudent);
                Console.WriteLine("Student Added.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Add canceled.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            }
        }
    }
    }

