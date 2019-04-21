using DDD.Commun.Dto;
using DDD.Model.AggregatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IConfirmerEntretien
    {
        Entretien Confirmer(EntretienDto entretien);
    }
}
