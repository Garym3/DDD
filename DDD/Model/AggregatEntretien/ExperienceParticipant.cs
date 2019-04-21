using System;
using DDD.Commun.Enum;

namespace DDD.Model.AggregatEntretien
{
    internal class ExperienceParticipant
    {
        public readonly Technologie NomTechnologie;

        public readonly int NbAnneesExperience;

        public ExperienceParticipant(Technologie nomTechnologie, int nbAnneesExperience)
        {
            NomTechnologie = nomTechnologie;
            NbAnneesExperience = nbAnneesExperience;
        }

        public override bool Equals(object obj)
        {
            return obj is ExperienceParticipant participant &&
                   NomTechnologie == participant.NomTechnologie &&
                   NbAnneesExperience == participant.NbAnneesExperience;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NomTechnologie, NbAnneesExperience);
        }
    }
}
