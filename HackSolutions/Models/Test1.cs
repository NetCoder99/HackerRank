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
        [Required(ErrorMessage = "String 1 is required.")]
        public string str1 { get; set; }
        public TestObj() { }
        public TestObj(string i_str)
        {
            this.str1 = i_str;
        }
    }
}