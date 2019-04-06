using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerConsole
{
    public class CamelCase
    {
        public static void Start()
        {
            string s = "saveChangesInTheEditor";
            int c = camelcase(s);
        }

        public static int camelcase(string s)
        {
            return Regex.Split(s, @"(?<!^)(?=[A-Z])").Length;
        }

    }
}
