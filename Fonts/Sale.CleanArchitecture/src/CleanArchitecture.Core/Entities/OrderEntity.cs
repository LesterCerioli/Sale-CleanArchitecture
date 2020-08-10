using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class OrderEntity : Entity, IAggregateRoot
    {
        public OrderEntity(Guid id, DateTime orderdate, DateTime deliverypreviouslydate)
        {
            Id = id;
            Orderdate = orderdate;
            Deliverypreviouslydate = deliverypreviouslydate;


        }
        protected OrderEntity() { }
        public DateTime Orderdate { get; set; }
        public DateTime Deliverypreviouslydate { get; set; }




    }
}