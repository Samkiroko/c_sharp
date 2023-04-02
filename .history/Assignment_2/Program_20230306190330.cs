using System;
namespace Assign
{
  public class MyClass
  {
    public static void Main()
    {
      // int a = 1;
      // int b = 2;
      // bool greaterAB = a > b;
      // bool equalAl = a == 1;

      // if (greaterAB)
      // {
      //   Console.WriteLine("a is greater than b");
      // }
      // else if (equalAl)
      // {
      //   Console.WriteLine("a is equal to 1");
      // }
      // else
      // {
      //   Console.WriteLine("a is less than b"); 
      // }



      using System;

class Solution
    {
      public int solution(string S)
      {
        int leftCount = 0;
        int rightCount = 0;
        int intervalCount = 0;
        for (int i = 0; i < S.Length; i++)
        {
          if (S[i] == 'L')
          {
            leftCount++;
          }
          else
          {
            rightCount++;
          }
          if (leftCount == rightCount)
          {
            intervalCount++;
            leftCount = 0;
            rightCount = 0;
          }
        }
        return intervalCount;
      }
    }

    class Program
    {
      static void Main(string[] args)
      {
        Solution solution = new Solution();
        Console.WriteLine(solution.solution("RLRRLLRLRRLL")); // should print 4
        Console.WriteLine(solution.solution("RLLLRRRLLR")); // should print 4
        Console.WriteLine(solution.solution("LLRLRLRLRLRLRR")); // should print 1
      }
    }


  }
}
}