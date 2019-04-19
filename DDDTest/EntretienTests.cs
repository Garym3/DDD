using DDD;
using System;
using System.Collections.Generic;
using DDD.Application;
using DDD.Application.Entretien;
using DDD.Application.Entretien.Participant.Atout;
using DDD.Models;
using DDD.Models.Entretien;
using DDD.Models.Entretien.Cr�neau;
using DDD.Models.Entretien.Participant.Atout;
using DDD.Models.Entretien.Participant.Candidat;
using DDD.Models.Entretien.Participant.Recruteur;
using Xunit;
using Xunit.Sdk;

namespace DDDTest
{
    public class EntretienTests
    {
        private DateTime _dateTime;
        private Cr�neau _cr�neau;
        private List<Exp�rienceParticipant> _exp�riencesCandidat;
        private List<Exp�rienceParticipant> _exp�riencesRecruteur1;
        private List<Exp�rienceParticipant> _exp�riencesRecruteur2;
        private Candidat _candidat;
        private List<Recruteur> _recruteurs;

        [Fact]
        public void DoitPlanifierEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            Assert.True(entretien.Statut == StatutEntretien.Planifi�);
        }

        [Fact]
        public void DoitConfirmerEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            entretien.Confirmer();

            Assert.True(entretien.Statut == StatutEntretien.Confirm�);
        }

        [Fact]
        public void DoitAnnulerEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            entretien.Annuler("Le candidat ne sera pas disponible.");

            Assert.True(entretien.Statut == StatutEntretien.Annul�);
        }

        [Fact]
        public void DeuxEntretiensNeDoiventPasSeChevaucher()
        {
            //Entretien entretien1 = InitialiseEchantillonEntretien();
            //Entretien entretien2 = ;

            //Assert.
        }


        private Entretien InitialiseEchantillonEntretien()
        {
            _dateTime = new DateTime(2019, 04, 19, 11, 20, 01);
            _cr�neau = new Cr�neau(_dateTime, 20);
            _exp�riencesCandidat = new List<Exp�rienceParticipant>
            {
                new Exp�rienceParticipant(Technologie.DotNet, 3),
                new Exp�rienceParticipant(Technologie.C, 4)
            };
            _exp�riencesRecruteur1 = new List<Exp�rienceParticipant>
            {
                new Exp�rienceParticipant(Technologie.DotNet, 3),
                new Exp�rienceParticipant(Technologie.C, 4)
            };

            _exp�riencesRecruteur2 = new List<Exp�rienceParticipant>
            {
                new Exp�rienceParticipant(Technologie.DotNet, 2),
                new Exp�rienceParticipant(Technologie.Java, 7)
            };
            _candidat = new Candidat("Bob", _exp�riencesCandidat);
            _recruteurs = new List<Recruteur>
            {
                new Recruteur("Jules", _exp�riencesRecruteur1),
                new Recruteur("Jean", _exp�riencesRecruteur2)
            };
            return new Entretien(_cr�neau, _candidat, _recruteurs);
        }
    }
}
