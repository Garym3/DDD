using System;
using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Commun.Enum;
using DDD.Model.AggregatEntretien;
using DDD.UseCase.UseCaseEntretien;
using Xunit;

namespace DDDTest
{
    public class EntretienTests
    {
        private static Entretien InitialiserEntretien(DateTime dateTime, int dureeEnMinutes)
        {
            var creneau = new CreneauDto(dateTime, dureeEnMinutes);
            var experiencesCandidatBob = new List<ExperienceParticipantDto>
            {
                new ExperienceParticipantDto(Technologie.DotNet, 3),
                new ExperienceParticipantDto(Technologie.C, 4)
            };
            var experiencesRecruteurJules = new List<ExperienceParticipantDto>
            {
                new ExperienceParticipantDto(Technologie.DotNet, 3),
                new ExperienceParticipantDto(Technologie.C, 4)
            };

            var experiencesRecruteurJean = new List<ExperienceParticipantDto>
            {
                new ExperienceParticipantDto(Technologie.DotNet, 2),
                new ExperienceParticipantDto(Technologie.Java, 7)
            };

            var candidat = new CandidatDto("Bob", experiencesCandidatBob);
            var recruteurs = new List<RecruteurDto>
            {
                new RecruteurDto("Jules", experiencesRecruteurJules),
                new RecruteurDto("Jean", experiencesRecruteurJean)
            };

            return new PlanifierEntretien().Planifier(creneau, candidat, recruteurs);
        }

        [Fact]
        public void DoitPlanifierEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            Assert.True(entretien.Statut == StatutEntretien.Planifie);
        }

        [Fact]
        public void DoitConfirmerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Confirmer();

            Assert.True(entretien.Statut == StatutEntretien.Confirme);
        }

        [Fact]
        public void DoitAnnulerEntretien()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annule);
        }

        [Fact]
        public void NeDoitPasRepasserAuStatutPlanifie()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annule);
        }

        [Fact]
        public void NeDoitPasRepasserAuStatutConfirme()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annule);
        }

        [Fact]
        public void NeDoitPasPasserAuStatutAnnule()
        {
            var entretien = InitialiserEntretien(new DateTime(2019, 04, 19, 11, 20, 01), 15);

            entretien.Annuler("Le candidat sera absent.");

            Assert.True(entretien.Statut == StatutEntretien.Annule);
        }
    }
}
