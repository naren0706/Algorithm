using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class BinarySearch
    {
        public void ReadAllText(string filepath)
        {
            string allText = File.ReadAllText(filepath);
            string[] words = allText.Split(",");
            Console.WriteLine("Enter the key to search");
            string key = Console.ReadLine();
            bool flag = false;
            foreach (string word in words)
            {
                if (word.Equals(key))
                {
                    flag = true;
                }
            }
            if(!flag)
                Console.WriteLine("not found");
            else
                Console.WriteLine("Search element {0} found",key);
        }
    }
}
