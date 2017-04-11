using System;
using System.IO;
namespace _04.Merge_Files
{
    public class Program
    {
       public static void Main()
        {
            var readFileOne = File.ReadAllLines("FileOne.txt");
            var readFileTwo = File.ReadAllLines("FileTwo.txt");
            for (int i = 0; i < readFileOne.Length; i++)
            {
                File.AppendAllText("result.txt", readFileOne[i] + Environment.NewLine);
                File.AppendAllText("result.txt", readFileTwo[i] + Environment.NewLine);
            }
        }
    }
}
