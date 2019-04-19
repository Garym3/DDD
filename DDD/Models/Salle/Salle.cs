using System;

namespace DDD.Models.Salle
{
    public class Salle
    {
        public readonly SalleId SalleId;

        public Salle()
        {
            SalleId = new SalleId();
        }

        public override bool Equals(object obj)
        {
            return obj is Salle salle && SalleId.Equals(salle.SalleId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SalleId);
        }
    }
}
