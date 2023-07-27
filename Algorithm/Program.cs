using System;

namespace Algorithm
{
    class Program
    {
        static string searchFilePath = @"E:\BridgeGateProblems\Algorithm\Algorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.binary Search\n2.Anagram\n3.String Replace");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadAllText(searchFilePath);
                        break;
                    case 2:
                        Anagrams anagrams = new Anagrams();
                        anagrams.IsAnagram();
                        break;
                    case 3:
                        StringReplace stringReplace = new StringReplace();
                        stringReplace.ReplaceString();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}