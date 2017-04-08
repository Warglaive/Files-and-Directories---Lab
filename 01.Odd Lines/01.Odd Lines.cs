using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
   public class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");
            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    File.AppendAllText("output.txt", text[i] + Environment.NewLine);
                }
            }
            File.WriteAllLines("output.txt", text.Where((lines, index) => index % 2 == 1));
        }
    }
}