using System;
using System.Linq;

namespace HackerConsole
{
    class Socks
    {
        public static void Start()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, 50, 10 };
            int result = FindMatchingSocks(ar);
            Console.WriteLine(result);
        }

        public static int FindMatchingSocks(int[] ar)
        {
            int cnt = 0;

            var qry = from ar_recs in ar
                      group ar_recs by ar_recs into ar_grp
                      where ar_grp.Count() > 1
                      select new { ar_grp, cnt = ar_grp.Count() } ;

            foreach (var ar_grp in qry)
            {
                if (ar_grp.cnt % 2 == 0)
                { cnt += ar_grp.cnt / 2;  }
                else
                { cnt += (ar_grp.cnt-1) / 2; }
            }

            return cnt;
        }
        
        

    }
}
