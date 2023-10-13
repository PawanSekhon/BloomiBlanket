using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloomiBlanket.Models
{
    public class Blanket
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name="Manufacturing Date")]
        [DataType(DataType.Date)]

        public DateTime ManufacturingDate { get; set; }
        [StringLength(75, MinimumLength = 5)]
        [Required]
        public string Material { get; set; }
        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string Size { get; set; }
        [StringLength(35, MinimumLength = 3)]
        [Required]

        public string Colour { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 10, ErrorMessage = "Customer rating must be between 1 and 10.")]
        public int CustomerRating { get; set; }
    }
}