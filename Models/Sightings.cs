using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace Bigfoot.Models
{
    public class Sightings
    {   
        public int ID { get; set; }

        [StringLength(20,MinimumLength = 4)]
        [Required]
        public string State { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Class { get; set; }
        public string ?Location { get; set; }

        [Required]
        public string? Occurence { get; set; }

        [Required]
        [StringLength(5000, MinimumLength = 10)]
        public string ?Description { get; set; }
        //public string Upload { get; set; }
        /*public string? PhotoPath { get; set; }*/

    }
}
