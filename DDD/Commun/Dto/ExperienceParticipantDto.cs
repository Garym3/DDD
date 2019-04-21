using DDD.Commun.Enum;

namespace DDD.Commun.Dto
{
    public class ExperienceParticipantDto
    {
        public Technologie NomTechnologie { get; set; }
        public int NbAnneesExperience { get; set; }

        public ExperienceParticipantDto(Technologie nomTechnologie, int nbAnneesExperience)
        {
            NomTechnologie = nomTechnologie;
            NbAnneesExperience = nbAnneesExperience;
        }
    }
}
