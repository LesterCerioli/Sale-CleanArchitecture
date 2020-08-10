using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class PFEntity : Entity, IAggregateRoot
    {
        public PFEntity(Guid id, string number)
        {
            Id = id;
            Number = number;

        }

        protected PFEntity() { }
        public string Number { get; set; }

    }
}