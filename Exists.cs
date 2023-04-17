using System;
using System.IO;
namespace filehandling1
{
public class Program
{
    public static void Main(string[] args)
    {
        string path= @"C:\Users\Sumon_\OneDrive\Desktop\Raja.txt";
        Console.WriteLine(path);
        
        if(File.Exists(path))
        {
            Console.WriteLine("Found");
        }
        else{
            Console.WriteLine("Not Found");
            File.Create(path);
        }
    }
}
}
