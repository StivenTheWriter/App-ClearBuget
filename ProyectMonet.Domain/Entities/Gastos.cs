using ProyectMoney.Domain.Entities;
namespace ProyectMoney.Domain.Entities
{
    public class Gastos: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; } = decimal.Zero;
        public string Description { get; set; } = string.Empty;

    }
}
