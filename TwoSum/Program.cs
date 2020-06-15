using System;
using System.Collections.Generic;
using System.Net;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var listCount = list.Count;

        for (int i=0; i < listCount; i++) 
        { 
            for (int j=0; j < listCount; j++) 
            {
                if (list[i] + list[j] == sum)
                {
                    return Tuple.Create(i, j); ;
                }
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
