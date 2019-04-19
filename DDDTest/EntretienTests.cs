using DDD;
using System;
using System.Collections.Generic;
using DDD.Application;
using DDD.Application.Entretien;
using DDD.Application.Entretien.Participant.Atout;
using DDD.Models;
using DDD.Models.Entretien;
using DDD.Models.Entretien.Créneau;
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
        private Créneau _créneau;
        private List<ExpérienceParticipant> _expériencesCandidat;
        private List<ExpérienceParticipant> _expériencesRecruteur1;
        private List<ExpérienceParticipant> _expériencesRecruteur2;
        private Candidat _candidat;
        private List<Recruteur> _recruteurs;

        [Fact]
        public void DoitPlanifierEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            Assert.True(entretien.Statut == StatutEntretien.Planifié);
        }

        [Fact]
        public void DoitConfirmerEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            entretien.Confirmer();

            Assert.True(entretien.Statut == StatutEntretien.Confirmé);
        }

        [Fact]
        public void DoitAnnulerEntretien()
        {
            Entretien entretien = InitialiseEchantillonEntretien();

            entretien.Annuler("Le candidat ne sera pas disponible.");

            Assert.True(entretien.Statut == StatutEntretien.Annulé);
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
            _créneau = new Créneau(_dateTime, 20);
            _expériencesCandidat = new List<ExpérienceParticipant>
            {
                new ExpérienceParticipant(Technologie.DotNet, 3),
                new ExpérienceParticipant(Technologie.C, 4)
            };
            _expériencesRecruteur1 = new List<ExpérienceParticipant>
            {
                new ExpérienceParticipant(Technologie.DotNet, 3),
                new ExpérienceParticipant(Technologie.C, 4)
            };

            _expériencesRecruteur2 = new List<ExpérienceParticipant>
            {
                new ExpérienceParticipant(Technologie.DotNet, 2),
                new ExpérienceParticipant(Technologie.Java, 7)
            };
            _candidat = new Candidat("Bob", _expériencesCandidat);
            _recruteurs = new List<Recruteur>
            {
                new Recruteur("Jules", _expériencesRecruteur1),
                new Recruteur("Jean", _expériencesRecruteur2)
            };
            return new Entretien(_créneau, _candidat, _recruteurs);
        }
    }
}
