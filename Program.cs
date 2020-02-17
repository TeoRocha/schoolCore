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
            Console.WriteLine(school.Name);
        }
    }
}
