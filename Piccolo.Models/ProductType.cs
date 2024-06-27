using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Type { get; set; }
    }
}
