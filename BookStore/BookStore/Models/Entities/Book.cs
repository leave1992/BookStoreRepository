using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public Image BookCover { get; set; }
    }
}