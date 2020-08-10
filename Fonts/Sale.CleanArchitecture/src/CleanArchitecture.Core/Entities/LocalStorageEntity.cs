using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class LocalStorageEntity : Entity, IAggregateRoot
    {
        public LocalStorageEntity(Guid id, string name, bool active)
        {
            Id = id;
            Name = name;
            Active = active;

        }

        protected LocalStorageEntity() { }
        public string Name { get; set; }
        public bool Active { get; set; }

    }
}