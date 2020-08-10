using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class PJEntity : Entity, IAggregateRoot
    {
        public PJEntity(Guid id, string number)
        {
            Id = id;
            Number = number;

        }

        protected PJEntity() { }
        public string Number { get; set; }




    }
}