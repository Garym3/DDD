using System.Collections.Generic;

namespace DDD.Commun.Dto
{
    public class CandidatDto
    {
        public string Nom;
        public List<ExperienceParticipantDto> Experiences;

        public CandidatDto(string nom, List<ExperienceParticipantDto> experiences)
        {
            Nom = nom;
            Experiences = experiences;
        }
    }
}
