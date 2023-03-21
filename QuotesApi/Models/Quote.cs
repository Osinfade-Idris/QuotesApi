using System.ComponentModel.DataAnnotations;

namespace QuotesApi.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; } 
        [Required]
        [StringLength(30)]
        public string Author { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public string Type { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
