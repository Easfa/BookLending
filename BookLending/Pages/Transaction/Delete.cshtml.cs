using BookLending.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages.Transaction
{
    public class DeleteModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Tid { get; set; }

        private readonly BookDbContext _db;

        public DeleteModel(BookDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            Model.Transaction trnrmv = _db.Transaction.Where(x => x.T_ID == Tid).FirstOrDefault();
            _db.Transaction.Remove(trnrmv);
            _db.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}
