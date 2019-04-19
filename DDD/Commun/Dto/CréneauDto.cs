using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Commun.Dto
{
    public class CréneauDto
    {
        public DateTime Date { get; set; }
        public int DuréeEnMinutes { get; set; }

        public CréneauDto(DateTime date, int duréeEnMinutes)
        {
            Date = date;
            DuréeEnMinutes = duréeEnMinutes;
        }
    }
}
