using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerConsole
{
    public class SOS
    {
        public static void Start()
        {
            string s = "SOS";
            int c = marsExploration(s);

            //s = "SOSSOSSOT";
            //c = marsExploration(s);

            //s = "SOSSPSSQSSOR";
            //c = marsExploration(s);
            //s = "POXSPSSQSSOR";
            //c = marsExploration(s);

            s = "SOSOOSOSOSOSOSSOSOSOSOSOSOS";
            c = marsExploration(s);
            

        }

        public static int marsExploration(string s)
        {
            if (s.Length > 99)     { return -1; }
            if (s.Length % 3 != 0) { return -1; }
            int errCount = 0;
            for (int i = 0; i < s.Length; i = i + 3)
            {
                string t1 = s.Substring(i, 3);
                if (t1[0] != 'S') { errCount++; }
                if (t1[1] != 'O') { errCount++; }
                if (t1[2] != 'S') { errCount++; }
            }
            return errCount;
        }


    }
}
