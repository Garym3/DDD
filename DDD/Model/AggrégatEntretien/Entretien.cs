using System;
using System.Collections.Generic;
using System.Linq;
using DDD.Commun.Dto;
using DDD.Commun.Enum;

namespace DDD.Model.AggrégatEntretien
{
    public class Entretien
    {
        private readonly EntretienId _entretienId;
        public StatutEntretien Statut { get; private set; }
        private Créneau _créneau;
        private Candidat _candidat;
        private List<Recruteur> _recruteurs;
        private RaisonAnnulationEntretien _raisonAnnulationEntretien;

        public Entretien(CréneauDto créneauDto, CandidatDto candidatDto, List<RecruteurDto> recruteursDto)
        {
            _entretienId = new EntretienId();

            Statut = StatutEntretien.Planifié;

            _créneau = new Créneau(créneauDto.Date, créneauDto.DuréeEnMinutes);

            _candidat = TransformerCandidatDto(candidatDto);

            _recruteurs = TransformerRecruteursDto(recruteursDto);

            _raisonAnnulationEntretien = null;
        }
        
        public void Confirmer()
        {
            if (Statut != StatutEntretien.Planifié) return;

            _raisonAnnulationEntretien = null;
            Statut = StatutEntretien.Confirmé;
        }

        public void Annuler(string raison)
        {
            if (Statut != StatutEntretien.Planifié) return;

            _raisonAnnulationEntretien = new RaisonAnnulationEntretien(raison);
            Statut = StatutEntretien.Annulé;
        }

        public override bool Equals(object obj)
        {
            return obj is Entretien entretien && _entretienId.Equals(entretien._entretienId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_entretienId, Statut, _créneau, _candidat, _recruteurs);
        }

        private static Candidat TransformerCandidatDto(CandidatDto candidatDto)
        {
            var expériencesCandidat = new List<ExpérienceParticipant>();

            foreach (var expérience in candidatDto.Expériences)
            {
                expériencesCandidat.Add(new ExpérienceParticipant(expérience.NomTechnologie, expérience.NbAnnéesExpérience));
            }

            return new Candidat(candidatDto.Nom, expériencesCandidat);
        }

        private static List<Recruteur> TransformerRecruteursDto(List<RecruteurDto> recruteursDto)
        {
            var recruteurs = new List<Recruteur>();

            foreach (var recruteur in recruteursDto)
            {
                var expériencesRecruteur = new List<ExpérienceParticipant>();

                foreach (var expérience in recruteur.Expériences)
                {
                    expériencesRecruteur.Add(new ExpérienceParticipant(expérience.NomTechnologie, expérience.NbAnnéesExpérience));
                }

                recruteurs.Add(new Recruteur(recruteur.Nom, expériencesRecruteur));
            }

            return recruteurs;
        }
    }
}
