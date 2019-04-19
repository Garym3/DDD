using System;
using DDD.Commun.Enum;

namespace DDD.Model.AggrégatEntretien
{
    internal class ExpérienceParticipant
    {
        public readonly Technologie NomTechnologie;

        public readonly int NbAnnéesExpérience;

        public ExpérienceParticipant(Technologie nomTechnologie, int nbAnnéesExpérience)
        {
            NomTechnologie = nomTechnologie;
            NbAnnéesExpérience = nbAnnéesExpérience;
        }

        public override bool Equals(object obj)
        {
            return obj is ExpérienceParticipant participant &&
                   NomTechnologie == participant.NomTechnologie &&
                   NbAnnéesExpérience == participant.NbAnnéesExpérience;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NomTechnologie, NbAnnéesExpérience);
        }
    }
}
