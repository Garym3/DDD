namespace DDD.Commun.Dto
{
    public class RaisonAnnulationEntretienDto
    {
        public string RaisonAnnulation { get; set; }

        public RaisonAnnulationEntretienDto(string raisonAnnulation)
        {
            RaisonAnnulation = raisonAnnulation;
        }
    }
}
