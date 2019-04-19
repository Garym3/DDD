using System;
using DDD.Application.Entretien.Participant.Atout;

namespace DDD.Models.Entretien.Participant.Atout
{
    public class ExpérienceParticipant
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
            var participant = obj as ExpérienceParticipant;
            return participant != null &&
                   NomTechnologie == participant.NomTechnologie &&
                   NbAnnéesExpérience == participant.NbAnnéesExpérience;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NomTechnologie, NbAnnéesExpérience);
        }
    }
}
