using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Enter a number to find all primes less than it: ");
      int userNumber = int.Parse(Console.ReadLine());

      Prime prime = new Prime(userNumber);
      List<int> primes = prime.GetPrimes();

      for (int i = 0; i < primes.Count; i++)
      {
        Console.WriteLine(primes[i]);
      }
    }
  }
}