using System;
using System.Collections.Generic;

namespace schoolCore.Entity
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public WorkingTime WorkingTime { get; set; }
        public List<Subject> subjects { get; set; }
        public List<Student> students { get; set; }
        public List<Test> Tests { get; set; }

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}