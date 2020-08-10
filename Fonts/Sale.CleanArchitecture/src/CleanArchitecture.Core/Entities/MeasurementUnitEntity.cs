using NetDevPack.Domain;
using System;

namespace CleanArchitecture.Core.Entities
{
    public class MeasurementUnitEntity : Entity, IAggregateRoot
    {
        public MeasurementUnitEntity(Guid id, string name, string symbol)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
        }

        protected MeasurementUnitEntity() { }


        public string Name { get; set; }
        public string Symbol { get; set; }

    }
}