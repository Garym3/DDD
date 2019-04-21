using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Model.AggregatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public class PlanifierEntretien : IPlanifierEntretien
    {
        public Entretien Planifier(CreneauDto creneau, CandidatDto candidat, List<RecruteurDto> recruteurs) => new Entretien(creneau, candidat, recruteurs);
    }
}
