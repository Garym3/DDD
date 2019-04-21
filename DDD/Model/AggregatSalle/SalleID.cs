using System;

namespace DDD.Model.AggregatSalle
{
    public class SalleId
    {
        public readonly Guid Id;

        public SalleId()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            return obj is SalleId id && Id.Equals(id.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
