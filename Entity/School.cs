namespace schoolCore.Entity
{
    class School
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CreationYear{ get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public School(string name, int creationYear) => (this.name, CreationYear) = (name, creationYear);
    }
}