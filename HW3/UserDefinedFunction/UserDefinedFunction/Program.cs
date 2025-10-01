using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedFunction
{
    class Program
    {
        static Dictionary<char, int> GetFreq(string word)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                } else
                {
                    freq[c] = 1;
                } 
            }
            return freq;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            var words = input.Split(',');

            foreach (string s in words)
            {
                string word = s.Trim(); 
                Dictionary<char, int> freq = GetFreq(word);
                
                int count = 0;
                foreach (var pair in freq)
                {
                    Console.Write($"{pair.Key}={pair.Value}");
                    count++;

                    if (count < freq.Count)
                    {
                        Console.Write(", ");
                    } 
                }

                Console.WriteLine(); 
            }

            Console.ReadKey();
        }   
    }
}
    

