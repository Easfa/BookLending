using BookLending.Model;
using Microsoft.EntityFrameworkCore;

namespace BookLending.Data
{
    public class BookDbContext : DbContext
    {
            public DbSet<Book> Books { get; set; }
            public DbSet<Person> Person { get; set; }
            public DbSet<Transaction> Transaction { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
            
        }
    }

}

