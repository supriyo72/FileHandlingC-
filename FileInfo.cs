using System;
using System.IO;
using System.Collections.Generic;

namespace filehandling4
{
class Program
{
    
    public static void Main(string[] args)
    {

        //Create Text file(Surya.txt) inside a folder name myfile
        /*
        FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt");
        FileStream fs= fi.Create();
        Console.WriteLine("File created");
        */

        //write a Text inside Surya.txt
        /*
        FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt");
        StreamWriter writer= fi.CreateText();
        writer.Write("Lti Supriyo Batch 2023");
        writer.Close();
        */

        //Delete a file
        /*
        FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt");
        fi.Delete();
        Console.WriteLine("File Deleted");
        */

        //CopyTo
        //Created a file because i have deleted it earlier

        //FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt");
        //FileStream fs= fi.Create();
        /*
        string path1= @"C:\Users\Sumon_\OneDrive\Desktop\myfile\Surya.txt";
        string path2= @"C:\Users\Sumon_\OneDrive\Desktop\Copy\Surya.txt";
        FileInfo f1= new FileInfo(path1);
        FileInfo f2= new FileInfo(path2);

        f1.CopyTo(path2);
        Console.WriteLine("File Copied");
        */

        //MoveTo
        /*
        string path1= @"C:\Users\Sumon_\OneDrive\Desktop\myfile\java.txt";
        string path2= @"C:\Users\Sumon_\OneDrive\Desktop\Copy\java.txt";
        FileInfo f1= new FileInfo(path1);
        FileInfo f2= new FileInfo(path2);

        f1.MoveTo(path2);
        Console.WriteLine("File Moved");
        */

        //OpenText Method
        /*
        FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\Copy\java.txt");
        StreamReader read= fi.OpenText();
        string res="";
        while((res=read.ReadLine()) != null)
        {
            Console.WriteLine(res);
        }
        */

        //Properties:
        FileInfo fi = new FileInfo(@"C:\Users\Sumon_\OneDrive\Desktop\Copy\java.txt");
        Console.WriteLine("Name: {0}",fi.Name);
        Console.WriteLine("Creation Time: {0}",fi.CreationTime);
        Console.WriteLine("Last Access Time: {0}",fi.LastAccessTime);
        Console.WriteLine("Length: {0}",fi.Length);
    }
}


}
