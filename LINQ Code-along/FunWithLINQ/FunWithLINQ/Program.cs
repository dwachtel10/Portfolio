using FunWithLINQ.Data;
using FunWithLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypes();
            Joins();
            GroupBy();
            Console.ReadLine();
        }

        static void AnonymousTypes()
        {
            Console.WriteLine("<= Anonymous Types");

            //create instance of repository
            
            StudentRepository repo = new StudentRepository();
            
            //get all the students

            List<Student> students = repo.GetAllStudents();

            //get all female students, return name and major

            //query syntax

            //var ladies = from s in students     //iterate collection of students
            //             where s.Gender == "F" // if Gender is Female return student
            //             select new
            //             {
            //                 newId = s.ID * 15,
            //                 Name = $"my name is {s.FirstName} {s.LastName}",
            //                 s.Major
            //             };

            //method syntax
            var ladies = students.Where(s => s.Gender == "F").Select(x => new
            {
                Name = $"my name is {x.FirstName} {x.LastName}",
                newId = x.ID * 15,
                x.Major
                
            });

            foreach (var lady in ladies)
            {
                Console.WriteLine($"{lady.Name} - {lady.Major} - {lady.newId}");
            }

            Console.WriteLine();

        }

        static void Joins()
        {
            Console.WriteLine("<= Joins");

            //create the repo
            var repo = new StudentRepository();

            //get collections
            var students = repo.GetAllStudents();
            var courses = repo.GetAllStudentCourses();

            //join students to their courses and write out the name and the course

            //Query Syntax
            //var results = from s in students //get all students
            //              join c in courses //join the courses
            //                on s.ID equals c.StudentId  //map ID to StudentID
            //                orderby s.FirstName //order results by firstname
            //              select new
            //              {
            //                  StudentName = $"{s.FirstName} {s.LastName}",
            //                  c.CourseName
            //              };

            //Method Syntax
            var results = students.Join(courses, s => s.ID, c => c.StudentId, (student, course) => new
            {
                course.CourseName,
                StudentName = $"{student.FirstName} {student.LastName}"
            });

            foreach (var result in results)
            {
                Console.WriteLine($"{result.StudentName} is taking {result.CourseName}.");
            }


            Console.WriteLine();
        }

        static void GroupBy()
        {
            //create repo

            var repo = new StudentRepository();

            //get student data
            var students = repo.GetAllStudents();

            //return students grouped by major

            //Query Syntax
            //var results = (from s in students
            //              //where s.Major != "Chemistry"
            //              orderby 
            //              //s.Major descending, 
            //              s.LastName
            //              group s by s.Major).Take(3);


            //Method Syntax
            var results = students.Where(s => s.Major != "Chemistry")
                .OrderByDescending(s => s.Major)
                .ThenBy(s => s.LastName)
                .GroupBy(s => s.Major)
                .Take(1);


            foreach (var group in results)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName} {student.LastName} - {student.Major}");
                }
            }


            Console.WriteLine();
        }
    }
}
