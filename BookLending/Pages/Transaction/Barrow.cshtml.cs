using BookLending.Data;
using BookLending.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLending.Pages.Transaction
{
    [BindProperties]
    public class BarrowModel : PageModel
    {
        public Book Book { get; set; }
        public Person Person { get; set; }
        public Model.Transaction Transaction { get; set; }
        private readonly BookDbContext _db;
        public BarrowModel(BookDbContext db) 
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            _db.Add(Book);
            _db.Add(Person);
            _db.SaveChanges();

            Transaction = new Model.Transaction(Person, Book, true);

            _db.Add(Transaction);
            _db.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}
