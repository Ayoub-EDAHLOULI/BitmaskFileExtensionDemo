namespace Bitmask
{
    [Flags]
    public enum FileExtensions
    {
        None = 0,
        PNG = 1 << 0, // 1
        JPG = 1 << 1, // 2
        PDF = 1 << 2, // 4
        XLSX = 1 << 3, // 8
        DOCX = 1 << 4, // 16
        TXT = 1 << 5, // 32
    }

    public class DocumentCategory
    {
        public required string Name { get; set; }
        public FileExtensions AcceptedExtensions { get; set; } = FileExtensions.None;

        public void ShowAcceptedExtension()
        {
            Console.WriteLine($"Document Category: {Name}");
            Console.WriteLine($"Accepted Extensions");
            foreach (FileExtensions ext in Enum.GetValues(typeof(FileExtensions)))
            {
                if (ext != FileExtensions.None && AcceptedExtensions.HasFlag(ext))
                {
                    Console.WriteLine($"- {ext}");
                }
            }
            Console.WriteLine($"Stored Bitmask Value: {(int)AcceptedExtensions}");
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create a category that accept PNG, JPG, PDF, and XLSX files
            DocumentCategory category1 = new()
            {
                Name = "Identity Documents",
                AcceptedExtensions = FileExtensions.PNG | FileExtensions.JPG | FileExtensions.PDF | FileExtensions.XLSX
            };

            // Another category that accept DOCX and TXT files
            DocumentCategory category2 = new()
            {
                Name = "Text Documents",
                AcceptedExtensions = FileExtensions.DOCX | FileExtensions.TXT
            };

            category1.ShowAcceptedExtension();
            category2.ShowAcceptedExtension();


            // Simulate checking if a category accepts a specific extension
            FileExtensions fileToCheck = FileExtensions.TXT;
            if (category1.AcceptedExtensions.HasFlag(fileToCheck))
            {
                Console.WriteLine($"{category1.Name} accepts {fileToCheck}");
            }
            else
            {
                Console.WriteLine($"{category1.Name} does not accept {fileToCheck}");
            }
        }
    }
}