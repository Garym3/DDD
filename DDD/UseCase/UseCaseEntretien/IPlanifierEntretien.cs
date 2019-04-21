using System.Collections.Generic;
using DDD.Commun.Dto;
using DDD.Model.AggregatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IPlanifierEntretien
    {
        Entretien Planifier(CreneauDto creneau, CandidatDto candidat, List<RecruteurDto> recruteurs);
    }
}
