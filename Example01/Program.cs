using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Random random = new Random();
      int length = 9;
      int[] numbers = new int[length];

      Console.WriteLine("<==== Check Process ====>");

      for (int count = 0; count < numbers.Length; count++)
      {
        int number = random.Next(0, length);
        Console.Write("cnt = " + count + ", ");
        Console.WriteLine("rnd = " + number);

        if (count == 0)
        {
          numbers[count] = number;
          Console.WriteLine("n[" + count + "] = " + numbers[count]);
        }
        else
        {
          bool IsUsed = false;
          for (int index = 0; index < count; index++)
          {
            IsUsed = numbers[index] == number;
            if (IsUsed)
            {
              break;
            }
          }
          if (!IsUsed)
          {
            numbers[count] = number;
            Console.WriteLine("n[" + count + "] = " + numbers[count]);
          }
          else
          {
            count--;
            Console.WriteLine(number + " 出現過了! 再生一個亂數!");
          }
        }
      }

      Console.WriteLine("<==== Output Results ====>");

      for (int i = 0; i < length; i++)
      {
        Console.WriteLine(numbers[i]);
      }
    }
  }
}