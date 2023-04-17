using System;
using System.IO;
namespace filehandling2
{
class Program
{
    static void Main()
    {
        string path= @"C:\Users\Sumon_\OneDrive\Desktop\Supu.txt";
    
    
        Console.WriteLine("Enter Text: ");
        string input1= Console.ReadLine();
        string input2= Console.ReadLine();
        
        try
        {
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(input1);
            writer.WriteLine(input2);
            writer.Close();
        }
        catch(IOException ex)
        {
            Console.WriteLine("Invalid "+ex.Message);
        }

        Console.WriteLine("Reading the contents of the file");

        try
        {
            TextReader reader= new StreamReader(path);
            string line= reader.ReadLine();
            Console.WriteLine($"The contents are {line}");
            reader.Close();
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}
}
