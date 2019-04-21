using DDD.Commun.Dto;
using DDD.Model.AggregatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IAnnulerEntretien
    {
        Entretien Annuler(EntretienDto entretien);
    }
}
