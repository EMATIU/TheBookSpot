using System.ComponentModel.DataAnnotations;

namespace TheBookSpot.Models
{
    public class Library
    {
        [Key]
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }


    }
}
