using System.ComponentModel.DataAnnotations;

namespace TheBookSpot.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set;  }
        public List<Author_Book> Authors_Books { get; set; }    

    }
}
