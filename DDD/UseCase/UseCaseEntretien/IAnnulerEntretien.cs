using DDD.Commun.Dto;
using DDD.Model.AggrégatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IAnnulerEntretien
    {
        Entretien Annuler(EntretienDto entretien);
    }
}
