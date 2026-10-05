namespace InheritanceExample
{
    public class Student : User // Student ärver från User och alla dess egenskaper
    {
        public List<string> Grades { get; set; }

        public Student(string name, string email, string role, List<string> grades)
        {
            Name = name;
            Email = email;
            Role = role;
            List<string> Grades = grades;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Roll: {Role}");
        }
    }
}
