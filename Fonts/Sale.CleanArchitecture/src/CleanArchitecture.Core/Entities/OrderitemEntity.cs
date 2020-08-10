

using NetDevPack.Domain;

namespace CleanArchitecture.Core.Entities
{
    public class OrderItemEntity : Entity, IAggregateRoot
    {
        public OrderItemEntity(Guid id, int amount)
        {
            Id = id;
            Amount = amount;

        }

        protected OrderItemEntity() { }
        public int Amount { get; set; }

    }
}