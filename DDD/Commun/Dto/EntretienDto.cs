using System;
using System.Collections.Generic;
using System.Text;
using DDD.Commun.Enum;

namespace DDD.Commun.Dto
{
    public class EntretienDto
    {
        public StatutEntretien Statut { get; set; }
        public CréneauDto Créneau { get; set; }
        public CandidatDto Candidat { get; set; }
        public List<RecruteurDto> Recruteurs { get; set; }
        public RaisonAnnulationEntretienDto RaisonAnnulationEntretien;

        public EntretienDto(RaisonAnnulationEntretienDto raisonAnnulationEntretien, StatutEntretien statut, CréneauDto créneau, CandidatDto candidat, List<RecruteurDto> recruteurs)
        {
            RaisonAnnulationEntretien = raisonAnnulationEntretien;
            Statut = statut;
            Créneau = créneau;
            Candidat = candidat;
            Recruteurs = recruteurs;
        }
    }
}
