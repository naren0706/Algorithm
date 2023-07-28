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
                Console.WriteLine("1.binary Search\n2.Anagram\n3.String Replace\n4.Insersion sort\n5.Bubble Sort\n6.Prime number from 0 - 1000\n7.PrimeNumber Anagram and palindrom");
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
                    case 4:
                        InsersionSort sort = new InsersionSort();
                        sort.Sort();
                        break;
                    case 5:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Sort();
                        break;
                    case 6:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.GetPrimeNumbers();
                        break;
                    case 7:
                        PrimeNumbers primeNumbers1 = new PrimeNumbers();
                        primeNumbers1.GetPrimeNumbers();
                        primeNumbers1.IsPrimeAnagramAndPalindrom();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}