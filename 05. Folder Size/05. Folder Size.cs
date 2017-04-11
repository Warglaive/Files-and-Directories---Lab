using System;
using System.IO;
namespace _05.Folder_Size
{
    public class Program
    {
       public static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                sum += info.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("result.txt", sum.ToString());
            Console.WriteLine(sum);
        }
    }
}