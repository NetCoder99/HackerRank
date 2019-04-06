using System;
using System.Collections.Generic;
using System.Text;

namespace HackerConsole
{
    class DiagDiff
    {
        public static void DiagDiffStart()
        {
            int[][] sq_arr4 = new int [][] {
                   new int [] { 1 , 2 , 3 , 4 },
                   new int [] { 1 , 2 , 3 , 4 },
                   new int [] { 1 , 2 , 3 , 4 },
                   new int [] { 1 , 2 , 3 , 4 } 
            };
            int diag_diff = diagonalDifference(sq_arr4);
            Console.WriteLine(diag_diff);



            sq_arr4 = new int[][] {
                new int [] {1, 2, 3 },
                new int [] {4, 5, 6 },
                new int [] {9, 8, 9 }
            };
            diag_diff = diagonalDifference(sq_arr4);
            Console.WriteLine(diag_diff);


            sq_arr4 = new int[][] {
                new int [] {11, 2, 4},
                new int [] {4,  5, 6},
                new int [] {10, 8, -12}
            };
            diag_diff = diagonalDifference(sq_arr4);
            Console.WriteLine(diag_diff);

        }


        public static int diagonalDifference(int[][] arr)
        {
            int p_sum = 0;
            int s_sum = 0;
            int f_idx = 0;
            int l_idx = arr.Length - 1;
            try
            {
                for (f_idx = 0; f_idx < arr.Length; f_idx++)
                {
                    p_sum += arr[f_idx][f_idx];
                    s_sum += arr[f_idx][l_idx];
                    l_idx--;
                }
                return Math.Abs(p_sum - s_sum);
            }
            catch (Exception ex)
            { throw new Exception("Array was not square");  }
        }
    }
}
