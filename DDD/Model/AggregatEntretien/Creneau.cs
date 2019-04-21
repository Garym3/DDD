using System;
using DDD.Commun.Exception;

namespace DDD.Model.AggregatEntretien
{
    internal class Creneau
    {
        public readonly DateTime Date;
        public readonly TimeSpan HeureDebut;
        public readonly TimeSpan HeureFin;

        public Creneau(DateTime date, int dureeEnMinutes)
        {
            dureeEnMinutes = ArrondirDureeEnMinutes(dureeEnMinutes);

            VerifierCreneauEstDansHeuresOuvrees(date, dureeEnMinutes);

            Date = date.Date;
            HeureDebut = date.TimeOfDay;
            HeureFin = HeureDebut.Add(new TimeSpan(dureeEnMinutes * 60 * 1000));
        }

        public override bool Equals(object obj)
        {
            return obj is Creneau creneau &&
                   Date == creneau.Date &&
                   HeureDebut.Equals(creneau.HeureDebut) &&
                   HeureFin.Equals(creneau.HeureFin);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Date, HeureDebut, HeureFin);
        }

        public override string ToString()
        {
            return $"Date : {Date.ToShortDateString()}\nDébut : {HeureDebut:HH:mm}\nFin : {HeureFin:HH:mm}";
        }

        private static int ArrondirDureeEnMinutes(int dureeEnMinutes)
        {
            if (dureeEnMinutes < 15)
            {
                return 15;
            }

            if (dureeEnMinutes % 15 > 0)
            {
                return (dureeEnMinutes / 15) * 15 + 15;
            }

            return dureeEnMinutes;
        }

        private static void VerifierCreneauEstDansHeuresOuvrees(DateTime date, int dureeEnMinutes)
        {
            if (date.Hour < 8)
            {
                throw new DureeHorsHeuresOuvreesException();
            }

            double duree = Convert.ToDouble(date.Hour) + Convert.ToDouble(dureeEnMinutes) / 60;

            if (duree > 20)
            {
                throw new DureeHorsHeuresOuvreesException();
            }
        }
    }
}
