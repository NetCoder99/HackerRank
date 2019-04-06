using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackSolutions.Models
{
    public class TripletModel
    {
        // the triplet must be in the form of 3 integers, seperated by 
        // spaces, no integer can be greater then 99
        public class Rating
        {

            [DataType(DataType.Text)]
            public string name { get; set; }

            [DataType(DataType.Text)]
            [Range(1, 100)]
            [Required(ErrorMessage = "Value must be between 1 and 100.")]
            public int rating1 { get; set; }

            [DataType(DataType.Text)]
            [Range(1, 100)]
            [Required(ErrorMessage = "Value must be between 1 and 100.")]
            public int rating2 { get; set; }

            [DataType(DataType.Text)]
            [Range(1, 100)]
            [Required(ErrorMessage = "Value must be between 1 and 100.")]
            public int rating3 { get; set; }

            public Rating() { }
            public Rating(string name, int r1, int r2, int r3)
            {
                this.name = name;
                this.rating1 = r1;
                this.rating2 = r2;
                this.rating3 = r3;
            }

        }

        public List<Rating> TripletList { get; set; }

        public TripletModel() {}



    }
}
