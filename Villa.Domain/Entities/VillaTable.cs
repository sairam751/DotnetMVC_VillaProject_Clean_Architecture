using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Domain.Entities
{
    public class VillaTable
    {
        public int Id { get; set; }
        
        public  string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string? Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10, 10000)]
        public double price { get; set; }
        public int sqft { get; set; }
        [Range(1, 10)]
        public int Occupancy { get; set; }
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
