using System.Collections.Generic;
using DDD.Commun.Enum;

namespace DDD.Commun.Dto
{
    public class EntretienDto
    {
        public StatutEntretien Statut { get; set; }
        public CreneauDto Creneau { get; set; }
        public CandidatDto Candidat { get; set; }
        public List<RecruteurDto> Recruteurs { get; set; }

        public RaisonAnnulationEntretienDto RaisonAnnulationEntretien;

        public EntretienDto(RaisonAnnulationEntretienDto raisonAnnulationEntretien, StatutEntretien statut, CreneauDto creneau, CandidatDto candidat, List<RecruteurDto> recruteurs)
        {
            RaisonAnnulationEntretien = raisonAnnulationEntretien;
            Statut = statut;
            Creneau = creneau;
            Candidat = candidat;
            Recruteurs = recruteurs;
        }
    }
}
