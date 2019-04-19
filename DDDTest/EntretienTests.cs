using System;
using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Commun.Enum;
using DDD.Commun.Exception;
using DDD.Model.Aggr�gatEntretien;
using DDD.UseCase.UseCaseEntretien;
using Xunit;

namespace DDDTest
{
    public class EntretienTests
    {
        private static Entretien InitialiserEntretien(DateTime dateTime, int dur�eEnMinutes)
        {
            var cr�neau = new Cr�neauDto(dateTime, dur�eEnMinutes);
            var exp�riencesCandidat = new List<Exp�rienceParticipantDto>
            {
                new Exp�rienceParticipantDto(Technologie.DotNet, 3),
                new Exp�rienceParticipantDto(Technologie.C, 4)
            };
            var exp�riencesRecruteur1 = new List<Exp�rienceParticipantDto>
            {
                new Exp�rienceParticipantDto(Technologie.DotNet, 3),
                new Exp�rienceParticipantDto(Technologie.C, 4)
            };

            var exp�riencesRecruteur2 = new List<Exp�rienceParticipantDto>
            {
                new Exp�rienceParticipantDto(Technologie.DotNet, 2),
                new Exp�rienceParticipantDto(Technologie.Java, 7)
            };
            var candidat = new CandidatDto("Bob", exp�riencesCandidat);
            var recruteurs = new List<RecruteurDto>
            {
                new RecruteurDto("Jules", exp�riencesRecruteur1),
                new RecruteurDto("Jean", exp�riencesRecruteur2)
            };

            return new PlanifierEntretien().Planifier(cr�neau, candidat, recruteurs);
        }

        [Fact]
        public void DoitPlanifierEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            Assert.True(entretien.Statut == StatutEntretien.Planifi�);
        }

        [Fact]
        public void DoitConfirmerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Confirmer();

            Assert.True(entretien.Statut == StatutEntretien.Confirm�);
        }

        [Fact]
        public void DoitAnnulerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annul�);
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest1()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 7, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest2()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 22, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest3()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 20, 0, 0), 15));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest4()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 19, 0, 0), 90));
        }
    }
}
