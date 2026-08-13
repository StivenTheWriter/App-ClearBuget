using ProyectMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProyectMoney.Infrastucture.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<DbContext> options): base(options) { }

        DbSet<Category> Categories { get; set; }
        DbSet<Gastos> Gastos { get; set; }
        DbSet<Income> Incomes { get; set; }




    }
}
