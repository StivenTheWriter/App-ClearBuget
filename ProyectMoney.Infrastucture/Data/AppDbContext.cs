using ProyectMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProyectMoney.Infrastucture.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<DbContext> options): base(options) { }

        DbSet<Category> Categories { get; set; }
        DbSet<Expense> Gastos { get; set; }
        DbSet<Income> Incomes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Income>()
                .Property(g => g.IncomeValue)
                .HasColumnType("Decimal(18,2)");


            modelBuilder.Entity<Expense>()
                .Property(g => g.Amount)
                .HasColumnType("Decimal18,2");
                
        }

    }
}
