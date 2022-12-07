namespace BookLending.Model
{
    public class Transactions
    {
        [Key]
        public int T_ID { get; set; }

        [ForeignKey("Persons")]
        public int P_ID { get; set; }
        public virtual Persons Person { get; set; }

        [ForeignKey("Books")]
        public int B_ID { get; set; }
        public virtual Books Book { get; set; }
    }
}
