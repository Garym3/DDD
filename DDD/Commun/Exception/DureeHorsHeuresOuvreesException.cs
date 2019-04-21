namespace DDD.Commun.Exception
{
    public class DureeHorsHeuresOuvreesException : System.Exception
    {
        public DureeHorsHeuresOuvreesException() : base($"Le créneau horaire doit se situer dans les heures ouvrées (8h00 à 20h00).")
        {

        }
    }
}
