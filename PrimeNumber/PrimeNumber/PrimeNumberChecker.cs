using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   class PrimeNumberChecker : InterfacePrimeChecker
   {
      public PrimeNumberChecker(PrimeNumberRepository objPrimeNumberRepository)
      {
         m_PrimeNumberRepository = objPrimeNumberRepository;
      }

      public bool IsNumberPrime(int number)
      {
         return m_PrimeNumberRepository.IsNumberInPrimeRepository(number);
      }

      private PrimeNumberRepository m_PrimeNumberRepository;
   }
}
