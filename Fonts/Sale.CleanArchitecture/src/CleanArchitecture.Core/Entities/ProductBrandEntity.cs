using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class ProductBrandEntity : Entity, IAggregateRoot
    {
        public ProductBrandEntity(Guid id, string name)
        {
            Id = id;
            Name = name;

        }
        protected ProductBrandEntity() { }
        public string Name { get; set; }


    }
}