﻿using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var hs = new HashSet<int>(list);

        for (int i = 0; i < list.Count; i++)
        {
            var diff = sum - list[i];
            if (hs.Contains(diff) && i != list.IndexOf(diff))
                return new Tuple<int, int>(i, list.IndexOf(diff));
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
