using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class MeasurementUnit : IAggregateRoot
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public MeasurementUnit(string name)
        {
            Name = name;
        }
    }
}