using BookLending.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages.Show
{
    public class LendsListModel : PageModel
    {
        public List<Model.Transaction> Transactions { get; set; }
        public string control;
        private readonly BookDbContext _db;
        public LendsListModel( BookDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            control = "Show/LendsList";
            Transactions = _db.Transaction.Where(x => x.LendingDate != null).ToList();

            foreach (var trans in Transactions)
            {
                trans.Person = _db.Person.Where(x => x.P_ID == trans.P_ID).FirstOrDefault();
                trans.Book = _db.Books.Where(x => x.B_ID == trans.B_ID).FirstOrDefault();
            }
        }
    }
}
