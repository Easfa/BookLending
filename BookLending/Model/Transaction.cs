using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLending.Model
{
    public class Transaction
    {
        [Key]
        public int T_ID { get; set; }

        [ForeignKey("Person")]
        public int P_ID { get; set; }
        public virtual Person Person { get; set; }

        [ForeignKey("Book")]
        public int B_ID { get; set; }
        public virtual Book Book { get; set; }

        public DateTime BarrowingDate { get; set; }
        
        public DateTime? LendingDate { get; set; }
    }
}
