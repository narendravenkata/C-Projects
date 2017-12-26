using FileSearch;
using System;
using System.Threading;
namespace FilesSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Directory");
            string directory = Console.ReadLine();
            FileSearchMethod fileSearch = new FileSearchMethod();
            fileSearch.SendFileName += SendFileName;
            fileSearch.Search(directory);
            Thread thread = new Thread(() => fileSearch.Search(directory));
            thread.Start();
        }
        static void SendFileName(string str)
        {
            Console.WriteLine(str);
        }
    }
}
