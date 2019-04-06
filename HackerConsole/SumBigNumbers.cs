using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace HackerConsole
{
    class SumBigNumbers
    {
        public static void SumBigNumbersStart()
        {
            long[] ar = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);

            ar = new long[] { Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
                            , Int32.MaxValue
            };
            result = aVeryBigSum(ar);
            Console.WriteLine(result);


            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = 5; // Convert.ToInt32(Console.ReadLine());

            //string s1 = "1000000001 1000000002 1000000003 1000000004 1000000005";
            //long[] ar = Array.ConvertAll(s1.Split(' '), arTemp => Convert.ToInt64(arTemp));

            ////long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            //long result = aVeryBigSum(ar);

            //Console.WriteLine(result);

            ////textWriter.Flush();
            ////textWriter.Close();


        }

        public static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }

    }
}
