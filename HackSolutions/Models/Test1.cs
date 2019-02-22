using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackSolutions.Models
{
    public class TestObj
    {
        [DataType(DataType.Text)]
        public string str1 { get; set; }
        [DataType(DataType.Text)]
        public int int1 { get; set; }
        public List<TestObj> TestList { get; set; }
        public TestObj() { }
        public TestObj(string i_str, int i_int)
        {
            this.str1 = i_str;
            this.int1 = i_int;
        }
    }
}