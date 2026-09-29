namespace CAFileHandling
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, string course, int marks)
        {
            Id = id;
            Name = name;
            Course = course;
            Marks = marks;
        }
    }
}
