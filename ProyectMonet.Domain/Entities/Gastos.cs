using ProyectMoney.Domain.Entities;
namespace ProyectMoney.Domain.Entities
{
    public class Gastos: BaseEntity
    {
        public string Description { get; set; } = string.Empty; // Ej: "Hamburguesa en McDonald's"
        public decimal Income { get; set; }

        // CRÍTICO: Esto es lo que te permite consultar meses anteriores
        public DateTime Date { get; set; } = DateTime.UtcNow;

        // RELACIÓN: Llave foránea hacia la Categoría
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
