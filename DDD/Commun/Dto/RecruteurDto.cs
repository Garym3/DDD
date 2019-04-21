using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Commun.Dto
{
    public class RecruteurDto
    {
        public string Nom;
        public List<ExperienceParticipantDto> Experiences;

        public RecruteurDto(string nom, List<ExperienceParticipantDto> experiences)
        {
            Nom = nom;
            Experiences = experiences;
        }
    }
}
