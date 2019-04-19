using System;

namespace DDD.Models.Entretien.Participant.Candidat
{
    public class CandidatId
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