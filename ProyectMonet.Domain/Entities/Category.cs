using System;


namespace ProyectMoney.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ColorHex { get; set; } = "#808080";

    }
}
