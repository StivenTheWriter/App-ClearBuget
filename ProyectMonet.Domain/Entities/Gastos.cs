
namespace ProyectMoney.Domain.Entities
{
    public class Gastos
    {
        public readonly Guid Id   = Guid.NewGuid();
        public String Name { get; set; } = string.Empty;
        public decimal Dinero { get; set; } = 0.0m;

        public bool IsDeleted = false;





    }
}
