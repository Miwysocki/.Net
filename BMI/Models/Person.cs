using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMI.Models
{
    public class Person
    {
        [MaxLength(15)]
       public string fname { get; set; }
        [Required]
        public string lname{ get; set; }
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }
        public string gender { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public float weight { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public float height { get; set; }
        [Range(0, 120)]
       public  int age { get; set; }
    }
}
