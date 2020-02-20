using System;
using schoolCore.Entity;

namespace schoolCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Tec Monterrey", 2012);
            school.Country = "México";
            school.City = "Monterrey";
            school.SchoolType = SchoolTypes.ElementarySchool;

            var course1 = new Course()
            {
                Name = "101"
            };

            var course2 = new Course()
            {
                Name = "201"
            };

            var course3 = new Course()
            {
                Name = "301"
            };

            Console.WriteLine(school);
            Console.WriteLine("===============");
            Console.WriteLine(course1.Name + ", " + course1.UniqueId);
            Console.WriteLine(course2.Name + ", " + course2.UniqueId);
            Console.WriteLine(course3.Name + ", " + course3.UniqueId);
        }
    }
}
