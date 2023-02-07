using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assigment3_1.Models
{
    public class Technician
    {
        public int TechnicianID { get; set; }
        [Required(ErrorMessage = "Technician Code Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Email Required")]

        public string? Phone { get; set; }
        [Required(ErrorMessage = "Phone Required")]

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

    }
}


 
    
       