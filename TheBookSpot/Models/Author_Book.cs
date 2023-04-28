using System.ComponentModel.DataAnnotations.Schema;

namespace TheBookSpot.Models
{
    public class Author_Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int AuthorId  { get; set; }
        public Author? Author { get; set; }  
    }
}
