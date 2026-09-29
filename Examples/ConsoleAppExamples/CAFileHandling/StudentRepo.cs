using System.Text.Json;

namespace CAFileHandling
{
    public class StudentRepo
    {
        private readonly string _dataFolder;
        private readonly string _filePath;

        public StudentRepo()
        {
            _dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            _filePath = Path.Combine(_dataFolder, "students.json");

            EnsureDataFileExists();
        }
        private void EnsureDataFileExists()
        {
            if (!Directory.Exists(_dataFolder))
                Directory.CreateDirectory(_dataFolder);
            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "[]");
        }

        public async Task<List<Student>> LoadAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(_filePath);
                return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading data: " + ex.Message);
                return new List<Student>();
            }
        }

        public async Task SaveAllAsync(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_filePath, json);
        }

        public void ExportReport(List<Student> students)
        {
            string reportPath = Path.Combine(_dataFolder, $"report_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            using StreamWriter writer = new StreamWriter(reportPath);
            writer.WriteLine("Student Report");
            writer.WriteLine("Generated: "+DateTime.Now);
            writer.WriteLine(new String('_',40));

            foreach (var s in students)
                writer.WriteLine($"{s.Id,-5} {s.Name,15} {s.Course,-15} {s.Marks,-5}");

            Console.WriteLine($"Report exported to {reportPath}");

            FileInfo fi = new FileInfo(reportPath);
            Console.WriteLine($"Report size: {fi.Length} bytes");
        }
    }
}
