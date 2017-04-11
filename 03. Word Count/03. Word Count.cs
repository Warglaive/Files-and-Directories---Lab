using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03.Word_Count
{
   public class Program
    {
       public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var text = File.ReadAllText("text.txt").ToLower()
                .Split(new[] { ' ', ',', '-', '!', '?', '\n', '\r' }
            , StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordsCount[word] = 0;
            }
            foreach (string word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }
            foreach (var item in wordsCount)
            {
                File.WriteAllLines("result.txt"
                    , wordsCount.OrderByDescending(x => x.Value)
                    .Select(x => x.Key + " - " + x.Value));
            }
        }
    }
}
