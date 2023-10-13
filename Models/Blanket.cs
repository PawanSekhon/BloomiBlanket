using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloomiBlanket.Models
{
    public class Blanket
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name="Manufacturing Date")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public int CustomerRating { get; set; }
    }
}