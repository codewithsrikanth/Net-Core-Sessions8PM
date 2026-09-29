namespace CAFileHandling
{
    class Example1
    {
        static void Main(string[] args)
        {
            string path = "logs.txt";

            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                for (int i = 1; i <= 5; i++)
                    writer.WriteLine($"Log Entry: #{i} at {DateTime.Now}");
            }


            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


        }
    }
}
