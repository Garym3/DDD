using System;

namespace DDD.Commun.Dto
{
    public class CreneauDto
    {
        public DateTime Date { get; set; }
        public int DureeEnMinutes { get; set; }

        public CreneauDto(DateTime date, int dureeEnMinutes)
        {
            Date = date;
            DureeEnMinutes = dureeEnMinutes;
        }
    }
}
