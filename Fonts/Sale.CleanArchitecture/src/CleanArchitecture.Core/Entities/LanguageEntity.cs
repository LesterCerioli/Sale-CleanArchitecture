using NetDevPack.Domain;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public class LanguageEntity : Entity, IAggregateRoot
    {
        public LanguageEntity(Guid id, string name, Guid storeuserentityid)
        {
            Id = id;
            Name = name;
            StoreUserEntityId = storeuserentityid;

        }
        protected LanguageEntity() { }

        public string Name { get; set; }
        public Guid StoreUserEntityId { get; set; }
        
    }
}