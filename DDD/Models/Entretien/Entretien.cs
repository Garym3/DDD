using System;
using System.Collections.Generic;
using DDD.Application.Entretien;
using DDD.Models.Entretien.Participant.Candidat;
using DDD.Models.Entretien.Participant.Recruteur;

namespace DDD.Models.Entretien
{
    public class Entretien
    {
        public readonly EntretienId EntretienId;
        public StatutEntretien Statut;
        public Créneau.Créneau Créneau;
        public Candidat Candidat;
        public List<Recruteur> Recruteurs;
        public RaisonAnnulationEntretien RaisonAnnulationEntretien;

        public Entretien(Créneau.Créneau créneau, Candidat candidat, List<Recruteur> recruteurs)
        {
            EntretienId = new EntretienId();
            Statut = StatutEntretien.Planifié;
            Créneau = créneau;
            Candidat = candidat;
            Recruteurs = recruteurs;
            RaisonAnnulationEntretien = null;
        }

        public void Confirmer()
        {
            RaisonAnnulationEntretien = null;
            Statut = StatutEntretien.Confirmé;
        }

        public void Annuler(string raison)
        {
            RaisonAnnulationEntretien = new RaisonAnnulationEntretien(raison);
            Statut = StatutEntretien.Annulé;
        }

        public override bool Equals(object obj)
        {
            return obj is Entretien entretien && EntretienId.Equals(entretien.EntretienId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EntretienId, Statut, Créneau, Candidat, Recruteurs);
        }
    }
}
