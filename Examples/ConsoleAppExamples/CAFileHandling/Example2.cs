namespace CAFileHandling
{
    class Example2
    {
        static void Main(string[] args)
        {
            string folder = "Reports";

            if (!Directory.Exists(folder)) 
            {
                Directory.CreateDirectory(folder);
                Console.WriteLine("Folder Created: "+folder);
            }

            string filepath = Path.Combine(folder, "reports1.txt");
            File.WriteAllText(filepath, "Report Generated on " + DateTime.Now.ToString());

            Console.WriteLine("Files in Folder: ");
            foreach(string f in Directory.GetFiles(folder))
                Console.WriteLine(" - "+Path.GetFileName(f)); 
        }
    }
}
