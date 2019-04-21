using System;
using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Commun.Enum;

namespace DDD.Model.AggregatEntretien
{
    public class Entretien
    {
        private readonly EntretienId _entretienId;
        public StatutEntretien Statut { get; private set; }
        private Creneau _creneau;
        private CandidatDto _candidat;
        private List<RecruteurDto> _recruteurs;
        private RaisonAnnulationEntretienDto _raisonAnnulationEntretien;

        public Entretien(CreneauDto creneauDto, CandidatDto candidatDto, List<RecruteurDto> recruteursDto)
        {
            _entretienId = new EntretienId();

            Statut = StatutEntretien.Planifie;

            _creneau = new Creneau(creneauDto.Date, creneauDto.DureeEnMinutes);

            _candidat = candidatDto;

            _recruteurs = recruteursDto;

            _raisonAnnulationEntretien = null;
        }
        
        public void Confirmer()
        {
            if (Statut != StatutEntretien.Planifie) return;

            _raisonAnnulationEntretien = null;
            Statut = StatutEntretien.Confirme;
        }

        public void Annuler(string raison)
        {
            if (Statut != StatutEntretien.Planifie) return;

            _raisonAnnulationEntretien = new RaisonAnnulationEntretienDto(raison);
            Statut = StatutEntretien.Annule;
        }

        public override bool Equals(object obj)
        {
            return obj is Entretien entretien && _entretienId.Equals(entretien._entretienId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_entretienId, Statut, _creneau, _candidat, _recruteurs);
        }
    }
}
