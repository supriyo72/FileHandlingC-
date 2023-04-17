using System;
using System.IO;
namespace filehandling6
{
public class Program
{
    public static void Main(string[] args)
    {
        WriteFile();
        ReadFile();
    }
    public static void WriteFile()
    {
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt";
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine("Hello SuryaKumar Yadav");
        writer.Close();

    }
    public static void ReadFile()
    {
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt";
        StreamReader reader= new StreamReader(path);
        string res= reader.ReadLine();
        Console.WriteLine(res);
        reader.Close();
    }
}
}
