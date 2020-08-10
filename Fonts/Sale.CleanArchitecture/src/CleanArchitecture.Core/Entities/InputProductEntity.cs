using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class InputProductEntity : Entity, IAggregateRoot
    {
        public InputProductEntity(Guid id, int number, DateTime date, int amount)
        {
            Id = id;
            Number = number;
            Date = date;
            Amount = amount;

        }
        protected InputProductEntity() { }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

    }
}