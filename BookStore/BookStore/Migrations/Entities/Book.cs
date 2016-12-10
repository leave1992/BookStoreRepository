using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Migrations.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required, StringLength(300, MinimumLength = 3)]
        public string Title { get; set; }
        [Required, StringLength(300, MinimumLength = 3)]
        public string Author { get; set; }
        [Required, StringLength(1000, MinimumLength = 3)]
        public string Description { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Genre { get; set; }
        [Required, Range(1, 1000), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public virtual Image Image { get; set; }
    }
}