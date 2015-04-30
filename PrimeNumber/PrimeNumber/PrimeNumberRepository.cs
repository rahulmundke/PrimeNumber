using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   class PrimeNumberRepository
   {
      public
      PrimeNumberRepository()
      {
         m_PrimeNumberSet = new SortedSet<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
      }

      public void AddPrimeNumber(int number)
      {
         m_PrimeNumberSet.Add(number);
      }

      public int GetNthPrimeNumber(int primeNumberIndex)
      {
         return m_PrimeNumberSet.ElementAt(primeNumberIndex);
      }

      public int GetPrimeNumberSetCount()
      {
         return m_PrimeNumberSet.Count();
      }

      public bool IsNumberInPrimeRepository(int number)
      {
         return m_PrimeNumberSet.Contains(number);
      }

      private
      SortedSet<int> m_PrimeNumberSet;

   }
}
