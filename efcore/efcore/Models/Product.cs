using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "nazwa")]
        [Required]

        public string name { get; set; }
        [Display(Name = "cena")]
        [Required]
        public decimal price { get; set; }
        [Display(Name = "kategoria")]
        public int CategoryID { get; set; }
        [Display(Name = "kategoria")]
        public Category category { get; set; }
    }
}
