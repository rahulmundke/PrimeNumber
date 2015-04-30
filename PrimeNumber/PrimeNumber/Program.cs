using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   class Program
   {
      static void Main(string[] args)
      {
         PrimeNumberRepository objPrimeNumberRepo = new PrimeNumberRepository();
         PrimeNumberBuilder objPrimeNumberBuilder = new PrimeNumberBuilder(objPrimeNumberRepo);
         objPrimeNumberBuilder.BuildPrimeSet(100);

         PrimeNumberChecker objPrimeNumberChecker = new PrimeNumberChecker(objPrimeNumberRepo);

         if (objPrimeNumberChecker.IsNumberPrime(33))
         {
            Console.WriteLine("Number 33 is prime");
         }
         else
            Console.WriteLine("Number 33 is not prime");

      }
   }
}
