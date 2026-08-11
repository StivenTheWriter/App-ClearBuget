using System;
namespace ProyectMoney.Domain.Entities
{
    // 1. CLASE BASE: Contiene todo lo necesario para el Offline-First.
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;


        //Campos de control para BD
        public bool IsSynced { get; set; } = false;
        public bool IsDeleted { get; set; } = false;


    }
}
