using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Model.AggrégatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IPlanifierEntretien
    {
        Entretien Planifier(CréneauDto créneau, CandidatDto candidat, List<RecruteurDto> recruteurs);
    }
}
