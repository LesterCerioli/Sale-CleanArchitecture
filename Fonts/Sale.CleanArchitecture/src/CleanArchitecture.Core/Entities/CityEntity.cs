
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.SharedKernel;
using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class CityEntity : Entity, IAggregateRoot
    {
        public CityEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        protected CityEntity() { }

        public string Name { get; set; }
    }
}
