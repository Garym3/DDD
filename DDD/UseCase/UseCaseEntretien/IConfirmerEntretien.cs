using DDD.Commun.Dto;
using DDD.Model.AggrégatEntretien;

namespace DDD.UseCase.UseCaseEntretien
{
    public interface IConfirmerEntretien
    {
        Entretien Confirmer(EntretienDto entretien);
    }
}
