using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   class PrimeNumberBuilder 
   {
      public
      PrimeNumberBuilder(PrimeNumberRepository ptrPrimeNumberRepository)
      {
         m_ptrPrimeNumberRepository = ptrPrimeNumberRepository;
      }


      public void BuildPrimeSet(int maxNumber)
      {
         for(int i = 31 ; i < maxNumber ; i=i+2)
         {
            if (!IsDivisibleByThree(i) && !IsDivisibleByFive(i) && !IsDivisibleByOtherPrime(i))
            {
               // found a prime, add it
               m_ptrPrimeNumberRepository.AddPrimeNumber(i);
            }
         }
      }

      private bool IsDivisibleByThree(int number)
      {
         // sum of digits of number if divisible by 3 then number is divisible by 3
         // do it only if number of digits are more than 4
         if (number > 9999)
         {
            number = GetSumOfDigits(number);
         }
         return number % 3 == 0;
      }

      private int GetSumOfDigits(int number)
      {
         int digitCount = 1;
         while (number > 0)
         {
            number = number >> 4;
            digitCount++;
         }
         return digitCount; 
      }

      private bool IsDivisibleByFive(int number)
      {
         // last digit if 0 or 5 then divisible
         int lastDigit = number % 10;
         return (lastDigit == 0 || lastDigit == 5) ? true : false;
      }

      private bool IsDivisibleByOtherPrime(int number)
      {
         int count = m_ptrPrimeNumberRepository.GetPrimeNumberSetCount();
         for (int i = 3; i < count; i++)
         {
            int primeNumber = m_ptrPrimeNumberRepository.GetNthPrimeNumber(i);
            if (number % primeNumber == 0)
               return true;
         }
         return false;
      }


      private
      PrimeNumberRepository m_ptrPrimeNumberRepository;
   }
}
