using System;
using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Commun.Enum;
using DDD.Commun.Exception;
using DDD.Model.AggrégatEntretien;
using DDD.UseCase.UseCaseEntretien;
using Xunit;

namespace DDDTest
{
    public class EntretienTests
    {
        private static Entretien InitialiserEntretien(DateTime dateTime, int duréeEnMinutes)
        {
            var créneau = new CréneauDto(dateTime, duréeEnMinutes);
            var expériencesCandidat = new List<ExpérienceParticipantDto>
            {
                new ExpérienceParticipantDto(Technologie.DotNet, 3),
                new ExpérienceParticipantDto(Technologie.C, 4)
            };
            var expériencesRecruteur1 = new List<ExpérienceParticipantDto>
            {
                new ExpérienceParticipantDto(Technologie.DotNet, 3),
                new ExpérienceParticipantDto(Technologie.C, 4)
            };

            var expériencesRecruteur2 = new List<ExpérienceParticipantDto>
            {
                new ExpérienceParticipantDto(Technologie.DotNet, 2),
                new ExpérienceParticipantDto(Technologie.Java, 7)
            };
            var candidat = new CandidatDto("Bob", expériencesCandidat);
            var recruteurs = new List<RecruteurDto>
            {
                new RecruteurDto("Jules", expériencesRecruteur1),
                new RecruteurDto("Jean", expériencesRecruteur2)
            };

            return new PlanifierEntretien().Planifier(créneau, candidat, recruteurs);
        }

        [Fact]
        public void DoitPlanifierEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            Assert.True(entretien.Statut == StatutEntretien.Planifié);
        }

        [Fact]
        public void DoitConfirmerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Confirmer();

            Assert.True(entretien.Statut == StatutEntretien.Confirmé);
        }

        [Fact]
        public void DoitAnnulerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annulé);
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest1()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 7, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest2()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 22, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest3()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 20, 0, 0), 15));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest4()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => InitialiserEntretien(new DateTime(2019, 4, 20, 19, 0, 0), 90));
        }
    }
}
