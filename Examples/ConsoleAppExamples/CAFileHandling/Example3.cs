namespace CAFileHandling
{
    class Example3
    {
        static StudentRepo _repo = new StudentRepo();
        static async Task Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Student Record Manager ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by Name");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Export Report");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddStudentAsync();
                        break;
                    case "2":
                        await ViewStudentsAsync();
                        break;
                    case "3":
                        await SearchStudentAsync();
                        break;
                    case "4":
                        await DeleteStudentAsync();
                        break;
                    case "5":
                        await ExportReportAsync();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            }
            Console.WriteLine("Good Night for today!");
        }

        static async Task AddStudentAsync()
        {
            List<Student> students = await _repo.LoadAllAsync();

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Course: ");
            string course = Console.ReadLine();

            Console.WriteLine("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            int newId = students.Count == 0 ? 1 : students.Max(s => s.Id) + 1;
            students.Add(new Student(newId, name, course, marks));

            await _repo.SaveAllAsync(students);
            Console.WriteLine("Student added successfully");
        }
        static async Task ViewStudentsAsync()
        {
            var students = await _repo.LoadAllAsync();

            if (students.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            foreach (var s in students)
                Console.WriteLine($"{s.Id}: {s.Name} | {s.Course} | Marks: {s.Marks}");
        }

        static async Task SearchStudentAsync()
        {
            Console.Write("Enter name to search: ");
            string query = (Console.ReadLine() ?? "").ToLower();

            var students = await _repo.LoadAllAsync();
            var results = students.Where(s => s.Name.ToLower().Contains(query)).ToList();

            if (results.Count == 0)
                Console.WriteLine("No matching student found.");
            else
                foreach (var s in results)
                    Console.WriteLine($"{s.Id}: {s.Name} | {s.Course} | Marks: {s.Marks}");
        }

        static async Task DeleteStudentAsync()
        {
            Console.Write("Enter Student ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var students = await _repo.LoadAllAsync();
            int removed = students.RemoveAll(s => s.Id == id);

            if (removed > 0)
            {
                await _repo.SaveAllAsync(students);
                Console.WriteLine("Student deleted.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static async Task ExportReportAsync()
        {
            var students = await _repo.LoadAllAsync();

            if (students.Count == 0)
            {
                Console.WriteLine("Nothing to export.");
                return;
            }

            _repo.ExportReport(students);
        }
    }
}
