using System;

namespace schoolCore.Entity
{
    public class Test
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Note { get; set; }

        public Test() => UniqueId = Guid.NewGuid().ToString();
    }
}