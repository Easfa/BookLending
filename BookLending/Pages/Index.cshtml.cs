using BookLending.Data;
using BookLending.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Book> Books { get; set; }
        public List<Person> Persons { get; set; }
        public List<Model.Transaction> Transactions { get; set; }
        private readonly BookDbContext _db;
        public IndexModel(ILogger<IndexModel> logger, BookDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Books = _db.Books.ToList();
            Persons = _db.Person.ToList();
            Transactions = _db.Transaction.Where(x => x.LendingDate == null).ToList();
        }
    }
}