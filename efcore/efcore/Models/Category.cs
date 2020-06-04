using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "nazwa")]
        [Required]

        public string longName { get; set; }
        [Display(Name = "skrót")]
        [Required]
        public string shortName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
