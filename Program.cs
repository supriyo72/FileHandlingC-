using System;
using System.IO;
using System.Collections.Generic;

namespace filehandling5
{
class Program
{
    public static void Main(string[] args)
    {
        //DirectoryInfo

        //Create
        /*
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\MyDir";
        DirectoryInfo di= new DirectoryInfo(path);
        di.Create();
        Console.WriteLine("Directory Created");
        */

        //SubDirectory
        /*
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\MyDir";
        DirectoryInfo di= new DirectoryInfo(path);
        DirectoryInfo dis= di.CreateSubdirectory("SubDir");
        Console.WriteLine("Sub-Directory Created");
        */

        // MoveTo Directory
        /*
        string path1=@"C:\Users\Sumon_\OneDrive\Desktop\MyDir";
        string path2=@"C:\Users\Sumon_\OneDrive\Desktop\Mydirectory\NewDir";
        DirectoryInfo d1= new DirectoryInfo(path1);
        DirectoryInfo d2= new DirectoryInfo(path2);
        d1.MoveTo(path2);
        Console.WriteLine("Path is Moved");
        */

        //Delete
        /*
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\Mumbai";
        DirectoryInfo di = new DirectoryInfo(path);
        di.Delete();
        Console.WriteLine("Path is Deleted");
        */

        //GetDirectories
        /*
        string path=@"C:\Users\Sumon_\OneDrive\Desktop\Mydirectory";
        try{
        DirectoryInfo d1= new DirectoryInfo(path);
        DirectoryInfo [] dir= d1.GetDirectories();
        Console.WriteLine("Length is: {0}",dir.Length);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        */

        //Properties
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\Sumon_\OneDrive\Desktop\Mydirectory\NewDir");
        Console.WriteLine("Name: {0}",di.Name);
        Console.WriteLine("Creation Time: {0}",di.CreationTime);
        Console.WriteLine("Last Access Time: {0}",di.LastAccessTime);
        Console.WriteLine("Last Write Time: {0}",di.LastWriteTime);
    }
}


}
