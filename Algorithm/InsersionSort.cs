using System;

namespace Algorithm
{
    internal class InsersionSort
    {
        internal void Sort()
        {
            Console.WriteLine("Enter the length of the arrat");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words[i] = Console.ReadLine();
            }
            for (int i = 1; i < n; i++)
            {
                string key = words[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(words[j], key) > 0)
                {
                    words[j + 1] = words[j];
                    j--;
                }
                words[j + 1] = key;
            }
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

        }
    }
}