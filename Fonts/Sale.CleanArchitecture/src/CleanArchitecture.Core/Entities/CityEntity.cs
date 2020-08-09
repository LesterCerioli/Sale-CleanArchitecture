using CleanArchitecture.Core.Events;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.SharedKernel;

namespace CleanArchitecture.Core.Entities
{
    public class CityEntity : Entity, IAggregateRoot
    {
        public CityEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public CityEntity() {}

        public string Name {get; set;}


    }
}
