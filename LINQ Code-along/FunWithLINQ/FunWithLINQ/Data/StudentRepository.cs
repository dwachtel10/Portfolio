using FunWithLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLINQ.Data
{
    public class StudentRepository
    {
        private List<Student> _students;
        private List<StudentCourse> _courses;

        //constructor; initialize our repository
        public StudentRepository()
        {
            _students = new List<Student>()
            {
                new Student() {ID = 1, FirstName = "Bart", LastName = "Simpson", Gender="M", Major="Chemistry" },
                new Student() {ID = 2, FirstName = "Lisa", LastName = "Simpson", Gender="F", Major="Political Science" },
                new Student() {ID = 3, FirstName = "Bugs", LastName = "Bunny", Gender="M", Major="Psychology" },
                new Student() {ID = 4, FirstName = "Lola", LastName = "Bunny", Gender="F", Major="Political Science" }
            };

            _courses = new List<StudentCourse>()
            {
                new StudentCourse() {StudentId = 1, CourseName = "Math" },
                new StudentCourse() {StudentId = 2, CourseName = "Math" },
                new StudentCourse() {StudentId = 3, CourseName = "Math" },
                new StudentCourse() {StudentId = 4, CourseName = "Math" },
                new StudentCourse() {StudentId = 2, CourseName = "Government" },
                new StudentCourse() {StudentId = 3, CourseName = "Intro to Programming" }
            };
            }

        public List<Student> GetAllStudents()
        {
            return _students;
        }
        public List<StudentCourse> GetAllStudentCourses()
        {
            return _courses;
        }
        }

    }


