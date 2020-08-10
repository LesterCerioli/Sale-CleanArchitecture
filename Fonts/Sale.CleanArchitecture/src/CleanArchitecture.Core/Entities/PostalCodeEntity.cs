using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class PostalCodeEntity : Entity, IAggregateRoot
    {
        public PostalCodeEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        protected PostalCodeEntity() { }

        public string Name { get; set; }

    }
}