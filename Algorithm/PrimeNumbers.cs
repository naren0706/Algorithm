using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class PrimeNumbers
    {
        public void GetPrimeNumbers() 
        { 
            var primeNumbers = new List<int>();
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
                    Console.WriteLine(i);
                    primeNumbers.Add(i);
                    count++;
                }
            }
        }
    }
}
