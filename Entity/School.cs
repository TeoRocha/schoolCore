using System;
using System.Collections.Generic;

namespace schoolCore.Entity
{
    public class School
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CreationYear{ get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public SchoolTypes SchoolType { get; set; }

        public Course[] Courses { get; set;}
        public List<Course> listCourses { get; set; }

        public School(string name, int creationYear) => (this.name, CreationYear) = (name, creationYear);

        public School(string name, int creationYear, 
                      SchoolTypes schoolTypes,
                      string country="",
                      string city="")
        {
            (this.name, CreationYear) = (name, creationYear);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: {name}, Type: {SchoolType} \nCountry: {Country}, City: {City}";
        }
    }
}