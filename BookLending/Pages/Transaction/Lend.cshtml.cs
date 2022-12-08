using BookLending.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages.Transaction
{
    public class LendModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Tid { get; set; }

        [BindProperty(SupportsGet = true)]
        public string control { get; set; }



        private readonly BookDbContext _db;

        public LendModel(BookDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            var trnrmv = _db.Transaction.Where(x => x.T_ID == Tid).FirstOrDefault();
            trnrmv.LendingDate = DateTime.Now;
            _db.SaveChanges();

            return RedirectToPage("/" + control);
        }
    }
}
