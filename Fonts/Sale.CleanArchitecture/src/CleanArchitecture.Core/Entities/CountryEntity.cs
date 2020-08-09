namespace CleanArchitecture.Core.Entities
{
    
    public class CityEntity : Entity, IAggregateRoot
    {
        public CountryEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public CountryEntity() {}

        public string Name {get; set;}


    }
    
    
    
    
    
        
}