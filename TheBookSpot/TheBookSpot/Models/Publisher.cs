using System.ComponentModel.DataAnnotations;

namespace TheBookSpot.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Book> Books { get; set; }
    }
}
