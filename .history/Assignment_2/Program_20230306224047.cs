using System;
namespace MyNamespace
{
  public class Program
  {
    static void Main(string[] args)
    {
      /*
      1. Start by initializing two variables, leftCount and rightCount, to 0. These variables will keep track of the number of left and right shoes seen so far.
Initialize another variable, intervalCount, to 0. This variable will keep track of the number of intervals found.
Iterate over the string, S, one character at a time, starting from the first character.
For each character, if it is an 'L', increment leftCount. If it is an 'R', increment rightCount.
If leftCount is equal to rightCount, increment intervalCount and reset leftCount and rightCount to 0.
After the iteration is complete, return the value of intervalCount.
      
      
      */



      static int solution(string S)
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
      Console.WriteLine($"{solution("RLRRLLRLRRLL")}");
      Console.WriteLine($"{solution("RLLLRRRLLR")}");
      Console.WriteLine($"{solution("LLRLRLRLRLRLRR")}");
    }
  }
}



