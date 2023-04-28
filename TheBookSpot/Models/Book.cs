using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheBookSpot.Data.Enums;

namespace TheBookSpot.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public BookCategory BookCategory { get; set; }
        public List<Author_Book> Authors_Books { get; set; }

        
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}
