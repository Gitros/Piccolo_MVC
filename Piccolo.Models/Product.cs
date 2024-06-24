using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ingredients { get; set; }
        [Required]
        public int PriceSmall { get; set; }
        [Required]
        public int PriceBig { get; set; }
    }
}
