using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3,4,{5},7,8
//2,3,4,6,7

namespace Algorithm
{
    internal class Anagrams
    {
        public void IsAnagram()
        {
            Console.WriteLine("Enter first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter first word");
            string word2 = Console.ReadLine();
            char[] arr = new char[26];
            int j = 0;
            
            for(int i = 0; (i < word1.Length)&&(word1.Length==word2.Length); i++) 
            {
                arr[word1[j] - 'a']++;
                arr[word2[j++] - 'a']--;
            }
            bool flag = true;
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] != 0)
                {
                    flag= false;
                    break;
                }
            }
            if( flag )
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not an Anagram");
            }
        }
    }
}
