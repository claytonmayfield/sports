using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Assigment3_1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product Code Required")]
        public string? ProductCode { get; set; }

        [Required(ErrorMessage = "Name Required")]

        public string? ProductName { get; set; }

        [Range(0, 1000000000)]
        [Column(TypeName = "decimal(11,2)")]

        public decimal YearlyPrice { get; set; }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
