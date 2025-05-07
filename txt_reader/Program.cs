using txt_reader;

internal class Program
{
    private static void Main(string[] args)
    {
        //string filePathTest = "C:\\Users\\Jan\\Desktop\\Full stack exercise\\c#\\testDocument.txt";
        string filePath = args[0];
        var reader = new Reader();  

        if (File.Exists(filePath))
        {
            if (args.Length > 1)
            {
                reader.FindArgOccurencies(args[0], args[1]);   
            } 
            else
            {
              reader.ReadFile(filePath);
            }
                
        }
        else
        {
            Console.WriteLine("Provide a valid file path.");
        }
    }
}