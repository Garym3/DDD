using System;
using System.Collections.Generic;
using DDD.Commun.Dto;

namespace DDD.UseCase
{
    public interface IRecupererRecruteurs
    {
        List<RecruteurDto> RecupererRecruteursDisponiblesPourEntretien(DateTime dateDebut, int dureeEnMinutes);
    }
}
