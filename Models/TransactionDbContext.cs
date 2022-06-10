using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    public class TransactionDbcontext : DbContext
    {
        public DbSet<Transaction> Transaction{get;set;}
        public TransactionDbcontext(DbContextOptions<TransactionDbcontext> contextOptions) : base(contextOptions)
        {
        }

        // protected TransactionDbcontext(DbContextOptions contextOptions)
        // : base(contextOptions)
    // {
    // }
    }
}