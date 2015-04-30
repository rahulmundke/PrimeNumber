using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeNumber
{
   class PrimeNumberRepository
   {
      public
      PrimeNumberRepository()
      {
         m_PrimeNumberSet = new SortedSet<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
         // Persiste the repository
         LoadPrimeRepositoryFromFile();
      }

      public void AddPrimeNumber(int number)
      {
         if(!m_PrimeNumberSet.Contains(number))
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

      public void PersistPrimeRepository()
      {
         try
         {
            StreamWriter writeFile = new StreamWriter("PrimeNumber.txt");

            for (int i = 0; i < m_PrimeNumberSet.Count; i++)
            {
               writeFile.WriteLine(m_PrimeNumberSet.ElementAt(i));
            }
            writeFile.Close();
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         }
      }

      public void LoadPrimeRepositoryFromFile()
      {
         try
         {
            StreamReader readFile = new StreamReader("PrimeNumber.txt");

            string readLine = readFile.ReadLine();
            while (readLine != "")
            {
               int primeNumber = int.Parse(readLine);
               m_PrimeNumberSet.Add(primeNumber);
               readLine = readFile.ReadLine();
            }
            readFile.Close();
         }
         catch(Exception e)
         {
            Console.WriteLine(e.Message);
            return;
         }
      }

      private
      SortedSet<int> m_PrimeNumberSet;

   }
}
