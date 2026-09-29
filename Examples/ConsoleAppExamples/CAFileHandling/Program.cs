namespace CAFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "notes.txt";

            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    Console.WriteLine("> " + line);
                }

                string content = File.ReadAllText(path);
                Console.WriteLine("Content: " + content);
            }
            else
            {
                File.WriteAllText(path, "Hello Srikanth, this is my first file\n");
                Console.WriteLine("File Written.");

                File.AppendAllText(path, "This is an appended line.\n");
            }
        }
    }
}
