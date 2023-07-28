using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class PrimeNumbers
    {
        List<int> primeNumbers = new List<int>();
        List<int> AnagramNPalindrome = new List<int>();
        public void GetPrimeNumbers() 
        { 
            int count = 0;
            Console.WriteLine("The prime numbers are");
            for (int i = 2; i < 1001; i++)
            {
                bool flag = true;
                for(int j=2;j*j < i+1; j++)
                {
                    if(i%j == 0)
                    {
                        flag=false;
                    }
                }
                if(flag)
                {
                    primeNumbers.Add(i);
                    count++;
                }
            }
        }
        static bool IsAnagram(int num1, int num2)
        {
            char[] num1Array = num1.ToString().ToCharArray();
            char[] num2Array = num2.ToString().ToCharArray();
            Array.Sort(num1Array);
            Array.Sort(num2Array);

            return new string(num1Array) == new string(num2Array);
        }
        static bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            int left = 0;
            int right = numStr.Length - 1;

            while (left < right)
            {
                if (numStr[left] != numStr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        public void IsPrimeAnagramAndPalindrom()
        {
            Console.WriteLine("palindrome     Anagrams");
            foreach (var a in primeNumbers)
            {
                foreach (var b in primeNumbers)
                {
                    if(IsAnagram(a, b) && IsPalindrome(a) && !a.Equals(b))
                    {
                        Console.WriteLine(a+"                "+b);
                        AnagramNPalindrome.Add(a);
                    }
                }
            }
        }
    }
}