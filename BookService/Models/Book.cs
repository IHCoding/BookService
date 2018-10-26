using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        public int Id  { get; set; }

        [Required]
        public string Title  { get; set; }

        public int Year{ get; set; }

        public decimal Price { get; set; }

        public string Genre { get; set; }

        // Foreign key to Author
        public int AuthorId { get; set; }

        //  navigation property to access the related Author in code
        public Author Author  { get; set; }
    }
}