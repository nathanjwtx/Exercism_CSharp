using System;
using System.Linq;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Anagram("BANANA");

            string[] words = new[] { "BANANA", "Banana", "banana" };

            var result = b.FindAnagrams(words);

            Console.WriteLine(string.Join(", ", result));

//            ListCheck();
            
        }

        static void ListCheck()
        {
            var a = "tapper";
            var b = "patter";
            
            var aa = a.ToList();
            var bb = b.ToList();
            aa.Sort();
            bb.Sort();
            
            var res = bb.Except(aa).ToList();
            var res1 = aa.Except(bb).ToList();
            
            Console.WriteLine(res.Count);
            Console.WriteLine(res1.Count);
        }
    }
}
