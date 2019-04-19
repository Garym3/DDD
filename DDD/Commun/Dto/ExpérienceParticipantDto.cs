using System;
using System.Collections.Generic;
using System.Text;
using DDD.Commun.Enum;

namespace DDD.Commun.Dto
{
    public class ExpérienceParticipantDto
    {
        public Technologie NomTechnologie { get; set; }
        public int NbAnnéesExpérience { get; set; }

        public ExpérienceParticipantDto(Technologie nomTechnologie, int nbAnnéesExpérience)
        {
            NomTechnologie = nomTechnologie;
            NbAnnéesExpérience = nbAnnéesExpérience;
        }
    }
}
