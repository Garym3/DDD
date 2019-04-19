using System.Collections.Generic;
using DDD.Models.Entretien;
using DDD.Models.Entretien.Créneau;
using DDD.Models.Entretien.Participant.Candidat;
using DDD.Models.Entretien.Participant.Recruteur;

namespace DDD.Application.Entretien
{
    public interface IEntretien
    {
        StatutEntretien Statut { get; set; }
        Créneau Créneau { get; set; }
        Candidat Candidat { get; set; }
        List<Recruteur> Recruteurs { get; set; }
        RaisonAnnulationEntretien RaisonAnnulationEntretien { get; set; }
    }
}
