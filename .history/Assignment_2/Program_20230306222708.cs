using System;
namespace MyNamespace
{
  class Program
  {
    static void Main(string[] args)
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
  }
}



