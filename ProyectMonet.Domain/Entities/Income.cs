using System;

namespace ProyectMoney.Domain.Entities
{
    public class Income: BaseEntity
    {
        public decimal income { get; set; } = decimal.Zero;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
