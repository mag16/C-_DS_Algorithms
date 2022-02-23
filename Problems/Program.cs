using System;
using System.Collections.Generic;

class TwoSum {
    public static Tuple<int, int> FindTwoSum (IList<int> list, int sum) {]
    //there is no length property for lists

        int tupleCount = list.Count;

        for (int i = 0; i < tupleCount; i++) {
            for (int j = i + 1; j < tupleCount; j++) {
                if (list[i] + list[j] == sum) {
                    return Tuple.Create<int, int> (i, j);;
                }
            };
        };

        return null;

    }

    public static void Main (string[] args) {
        Tuple<int, int> indices = FindTwoSum (new List<int> () { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null) {
            Console.WriteLine (indices.Item1 + " " + indices.Item2);
        }
    }
}