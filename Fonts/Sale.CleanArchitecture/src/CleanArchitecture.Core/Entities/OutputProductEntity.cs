using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class OutputProductEntity : Entity, IAggregateRoot
    {
        public OutputProductEntity(Guid id, int number, DateTime date, int amount)
        {
            Id = id;
            Number = number;
            Date = date;
            Amount = amount;

        }
        protected OutputProductEntity() { }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

    }
}