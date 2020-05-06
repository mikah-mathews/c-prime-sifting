using System.Collections.Generic;
using System;
namespace PrimeSifting.Models
{
  public class Prime
  {
    /* Make List from 2 -> number
     * Set Prime = 2
     * Loop through list and remove if number % 2 == 0
     * Add 1 to Prime, repeat
     * When Prime = number, finsihed. all that remain are prime.
    */
    private List<int> _numbers;
    private int _number;

    public Prime(int number)
    {
      _numbers = new List<int>();
      _number = number;
      //=========================================================
      for (int j = 2; j < number; j++)
      {
        if (isPrime(j))
        {
          _numbers.Add(j);
        }
      }
    }

    public List<int> GetPrimes()
    {
      return _numbers;
    }

    public bool isPrime(int number)
    {
      if (number <= 1)
      {
        return false;
      }

      for (int i = 2; i < number; i++)
      {
        if (number % i == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}