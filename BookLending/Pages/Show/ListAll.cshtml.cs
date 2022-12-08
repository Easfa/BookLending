using BookLending.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages.Show
{
    public class ListAllModel : PageModel
    {
        public List<Model.Transaction> Transactions { get; set; }
        private readonly BookDbContext _db;
        public ListAllModel(BookDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Transactions = _db.Transaction.ToList();

            foreach (var trans in Transactions)
            {
                trans.Person = _db.Person.Where(x => x.P_ID == trans.P_ID).FirstOrDefault();
                trans.Book = _db.Books.Where(x => x.B_ID == trans.B_ID).FirstOrDefault();
            }
        }
    }
}
