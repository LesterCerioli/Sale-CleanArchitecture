using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class ProductEntity : Entity, IAggregateRoot
    {
        public ProductEntity(Guid id, string name, string description, decimal costprice, decimal saleprice)
        {
            Id = id;
            Name = name;
            Description = description;
            Costprice = costprice;
            Saleprice = saleprice;
        }
        protected ProductEntity() { }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Costprice { get; set; }
        public decimal Saleprice { get; set; }


    }
}