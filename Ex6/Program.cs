using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6
{
    class Program
    {
    public static List<int> getNewList(List<int> list)
    {

        List<int> list2 = new List<int>();
        foreach (int item in list)
        {
            if (condition(item))
                list2.Add(item);
        }
        return list2;
    }

    static bool condition(int x)
    {
        return x % 2 == 0;
    }

    static void Main(string[] args)
    {
        List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };

        foreach (int item in getNewList(list))
        {
            Console.WriteLine(item);
        }
    }
}
}
