using System;
using System.ComponentModel.DataAnnotations;

namespace BloomiBlanket.Models
{
    public class Blanket
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
        public int CustomerRating { get; set; }
    }
}