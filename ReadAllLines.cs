using System;
using System.IO;
using System.Collections.Generic;

namespace filehandling3
{
class Program
{
    static string path= @"C:\Users\Sumon_\OneDrive\Desktop\Supu.txt";
    public static void Main(string[] args)
    {
        write3Line();
        readWholeFile();
    }

    public static void write3Line()
    {
        Console.WriteLine("Enter Text: ");
        string input1= Console.ReadLine();
        string input2= Console.ReadLine();
        string input3= Console.ReadLine();
        
        try
        {
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(input1);
            writer.WriteLine(input2);
            writer.WriteLine(input3);
            writer.Close();
        }
        catch(IOException ex)
        {
            Console.WriteLine("Invalid "+ex.Message);
        }
    }
    public static void readWholeFile()
    {
        List<string> lines = new List<string>();
        try
        {
            TextReader reader= new StreamReader(path);
           
            string buffer="";

            while((buffer=reader.ReadLine()) != null)
            {
                lines.Add(buffer);
            }
            reader.Close();
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }

        Console.WriteLine("The contents of the file are: ");
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }
        
    }

}
}
