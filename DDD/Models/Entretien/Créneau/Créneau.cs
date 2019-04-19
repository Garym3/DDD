using System;
using DDD.Application.Entretien;

namespace DDD.Models.Entretien.Créneau
{
    public class Créneau
    {
        public readonly DateTime Date;
        public readonly TimeSpan HeureDébut;
        public readonly TimeSpan HeureFin;

        #region Constructeur

        public Créneau(DateTime date, int duréeEnMinutes)
        {
            duréeEnMinutes = ArrondirDuréeEnMinutes(duréeEnMinutes);

            VérifierQueLeCréneauEstDansLesHeuresOuvrées(date, duréeEnMinutes);

            Date = date.Date;
            HeureDébut = date.TimeOfDay;
            HeureFin = HeureDébut.Add(new TimeSpan(duréeEnMinutes * 60 * 1000));
        }

        #endregion

        #region Equals

        public override bool Equals(object obj)
        {
            return obj is Créneau créneau &&
                   Date == créneau.Date &&
                   HeureDébut.Equals(créneau.HeureDébut) &&
                   HeureFin.Equals(créneau.HeureFin);
        }

        #endregion

        #region GetHashCode

        public override int GetHashCode()
        {
            return HashCode.Combine(Date, HeureDébut, HeureFin);
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            return $"Date : {Date.ToShortDateString()}\nDébut : {HeureDébut.ToString("HH:mm")}\nFin : {HeureFin.ToString("HH:mm")}";
        }

        #endregion

        #region ArrondirDuréeEnMinutes

        private int ArrondirDuréeEnMinutes(int duréeEnMinutes)
        {
            if (duréeEnMinutes < 15)
            {
                return 15;
            }

            if (duréeEnMinutes % 15 > 0)
            {
                return (duréeEnMinutes / 15) * 15 + 15;
            }

            return duréeEnMinutes;
        }

        #endregion

        #region VérifierQueLeCréneauEstDansLesHeuresOuvrées

        private void VérifierQueLeCréneauEstDansLesHeuresOuvrées(DateTime date, int duréeEnMinutes)
        {
            if (date.Hour < 8)
            {
                throw new DuréeHorsHeuresOuvréesException();
            }

            double durée = Convert.ToDouble(date.Hour) + Convert.ToDouble(duréeEnMinutes) / 60;

            if (durée > 20)
            {
                throw new DuréeHorsHeuresOuvréesException();
            }
        }

        #endregion
    }
}
