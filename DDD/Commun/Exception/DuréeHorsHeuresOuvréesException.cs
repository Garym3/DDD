namespace DDD.Commun.Exception
{
    public class DuréeHorsHeuresOuvréesException : System.Exception
    {


        public DuréeHorsHeuresOuvréesException() : base($"Le créneau horaire doit se situer dans les heures ouvrées (8h00 à 20h00)")
        {

        }
    }
}
