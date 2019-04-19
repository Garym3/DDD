using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Model.AggrégatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public class PlanifierEntretien : IPlanifierEntretien
    {
        public Entretien Planifier(CréneauDto créneau, CandidatDto candidat, List<RecruteurDto> recruteurs) => new Entretien(créneau, candidat, recruteurs);
    }
}
