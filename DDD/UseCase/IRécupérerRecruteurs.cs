using System;
using System.Collections.Generic;
using System.Text;
using DDD.Commun.Dto;

namespace DDD.UseCase
{
    public interface IRécupérerRecruteurs
    {
        List<RecruteurDto> RécupérerRecruteursDisponiblesPourEntretien(DateTime dateDébut, int duréeEnMinutes);
    }
}
