using System;

namespace DDD.Model.AggregatEntretien
{
    internal class CandidatId
    {
        public readonly Guid Id;

        public CandidatId()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            return obj is CandidatId iD && Id.Equals(iD.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}