using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{

    public class CountryEntity : Entity, IAggregateRoot
    {
        public CountryEntity(Guid id, string name)
        {
            Id = id;
            Name = name;

        }
        protected CountryEntity() { }
        public string Name { get; set; }



    }





}