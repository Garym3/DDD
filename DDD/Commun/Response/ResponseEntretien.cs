using DDD.Commun.Dto;

namespace DDD.Commun.Response
{
    public class ResponseEntretien
    {
        public EntretienDto Entretien { get; set; }
        public string ResponseCode { get; set; }
    }
}
