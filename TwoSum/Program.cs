using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var hs = new HashSet<int>();
        list.ToList().ForEach(x => hs.Add(x));

        for (int i = 0; i < hs.Count; i++)
        {
            var diff = sum - list[i];
            if (hs.Contains(diff) && i != list.IndexOf(diff))
            {
                var index = list.IndexOf(diff);
                return new Tuple<int, int>(i, index);
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
