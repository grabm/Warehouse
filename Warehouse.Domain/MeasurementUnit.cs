namespace Warehouse.Domain
{
    public class MeasurementUnit
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public MeasurementUnit(string name)
        {
            Name = name;
        }
    }
}