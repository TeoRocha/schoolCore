using schoolCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace schoolCore
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
            
        }

        public void Init()
        {
            School = new School("Tec Monterrey", 2012, SchoolTypes.ElementarySchool, country: "México", city: "Monterrey");
            CreateCourses();
            CreateSubjects();
            CreateTests();
        }

        private void CreateSubjects()
        {
            foreach (var course in School.listCourses)
            {
                List<Subject> listSubjects = new List<Subject>(){
                    new Subject{Name="Math"},
                    new Subject{Name="Sports"},
                    new Subject{Name="Spanish"},
                    new Subject{Name="English"}
                };
                course.subjects = listSubjects ;
            }
        }

        private void CreateTests()
        {
            var listTests = from stnt in School.listCourses.students
                            from sjct in School.listCourses.subjects
                            select new Test{ Name=$"{sjct} test", Student=stnt, Subject=sjct };
        }

        private List<Student> CreateStudents( int size )
        {
            string[] name1 =    {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] lastName = {"Ruiza", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};
            string[] name2 =    {"Freddy", "Anable", "Rick", "Murty", "Silvana", "López", "Casas"};

            var listStudents = from n1 in name1
                                from n2 in name2
                                from l1 in lastName
                                select new Student{ Name=$"{n1} {n2} {l1}"};
            return listStudents.OrderBy( (a1)=> a1.UniqueId ).Take(size).ToList();
        }

        private void CreateCourses()
        {
            School.listCourses = new List<Course>() {
                new Course() {Name = "101", WorkingTime = WorkingTime.Morning },
                new Course() {Name = "201", WorkingTime = WorkingTime.Morning },
                new Course() {Name = "301", WorkingTime = WorkingTime.Morning },
                new Course() {Name = "401", WorkingTime = WorkingTime.Noon },
                new Course() {Name = "501", WorkingTime = WorkingTime.Noon }
            };

            Random rnd = new Random();
            
            foreach (var c in School.listCourses)
            {
                c.students = CreateStudents( rnd.Next(5, 20) );
            }
        }
    }
}