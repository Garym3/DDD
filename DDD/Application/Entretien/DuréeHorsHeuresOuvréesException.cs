using System;

namespace DDD.Application.Entretien
{
    public class DuréeHorsHeuresOuvréesException : Exception
    {


        public DuréeHorsHeuresOuvréesException() : base($"Le créneau horaire doit se situer dans les heures ouvrées (8h00 à 20h00)")
        {

        }
    }
}
