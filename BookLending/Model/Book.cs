using System.ComponentModel.DataAnnotations;

namespace BookLending.Model
{
    public class Book
    {
        [Key]
        public int B_ID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int PageNumbers { get; set; }

        public Book() { }
        public Book(string bookname, string bookauthor, int pagenumbers) { BookName = bookname; BookAuthor = bookauthor; PageNumbers = pagenumbers; }

    }
}
