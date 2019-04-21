using System;

namespace DDD.Model.AggregatEntretien
{
    internal class RecruteurId
    {
        public readonly Guid Id;

        public RecruteurId()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            return obj is RecruteurId id && Id.Equals(id.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}