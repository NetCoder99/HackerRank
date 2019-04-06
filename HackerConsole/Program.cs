// Appears to be a mix of Java and C#, not prepared for Java
// Question 5 was not valid, Stack requires a type!



using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerConsole
{
    class Program
    {

        static void Main(string[] args)
        {

            SOS.Start();

            //Console.WriteLine("Hello World!");
            //SumBigNumbers.SumBigNumbersStart();
            //DiagDiff.DiagDiffStart();
            //Socks.Start();

            //List<int> arr = new List<int> { 1, 2, 3, 5, 6 };
            //Console.WriteLine(findNumber(arr, 4));

            //List<int> arr = oddNumbers(2, 5);
            //arr = oddNumbers(3, 9);

            //Stack st = new Stack();




            //int i;
            //DoTask(out i);
            //Console.WriteLine(i);

            //List<string> ops = new List<string>() { "push", "push", "push", "pop" };
            //List<int> vals = new List<int>() {1, 2, 3, 1 };
            //minMax(ops, vals);

            //List<string> ops = new List<string>() { "push"};
            //List<int> vals = new List<int>() { 4 };
            //minMax(ops, vals);

        }

        static List<int> elements = new List<int>();

        static List<long> minMax(List<string> ops, List<int> vals)
        {
            List<long> products = new List<long>();
            for (int i = 0; i < ops.Count; i++)
            {
                if (ops[i] == "push")
                { elements.Add(vals[i]);  }
                if (ops[i] == "pop")
                {
                    int last = elements.LastIndexOf(vals[i]);
                    elements.RemoveAt(last);
                }
                int[] tmp = elements.ToArray().OrderBy(o => o).ToArray();
                int min = elements[0];
                int max = elements[elements.Count-1];
                products.Add(min * max);
            }
            return products;
        }


        static void DoTask(out int i)
        {
            i = 6;
        }
        
        // Complete the oddNumbers function below.
        static  List<int> oddNumbers(int l, int r)
        {
            List<int> rtn_list = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                { rtn_list.Add(i);  }
            }
            return rtn_list;
        }


        public static string findNumber(List<int> arr, int k)
        {
            if (arr.Contains(k))
            { return "YES"; }
            else
            { return "NO"; }
        }
    }
}
