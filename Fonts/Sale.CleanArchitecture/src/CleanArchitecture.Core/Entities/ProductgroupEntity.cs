using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class ProductGroupEntity : Entity, IAggregateRoot
    {
        public ProductGroupEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        protected ProductGroupEntity() { }

        public string Name { get; set; }

    }
}