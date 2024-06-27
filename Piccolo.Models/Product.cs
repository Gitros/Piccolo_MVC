using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        [Required]
        public int Position { get; set; }
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType? ProductType { get; set; }
        
    }
}
