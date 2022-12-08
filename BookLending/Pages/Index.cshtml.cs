using BookLending.Data;
using BookLending.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages
{
    public class IndexModel : PageModel
    { 
        public List<Model.Transaction> Transactions { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly BookDbContext _db;
        public IndexModel(ILogger<IndexModel> logger, BookDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Transactions = _db.Transaction.Where(x => x.LendingDate == null).ToList();

            foreach(var trans in Transactions) 
            {
                trans.Person = _db.Person.Where(x => x.P_ID == trans.P_ID).FirstOrDefault();
                trans.Book = _db.Books.Where(x => x.B_ID == trans.B_ID).FirstOrDefault();
            }
        }

    }
}