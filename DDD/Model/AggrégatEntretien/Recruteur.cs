using System;
using System.Collections.Generic;
using DDD.Commun.Dto;

namespace DDD.Model.AggrégatEntretien
{
    internal class Recruteur
    {
        public readonly RecruteurId RecruteurId;
        public readonly string Nom;
        public readonly List<ExpérienceParticipant> Expériences;

        public Recruteur(string nom, List<ExpérienceParticipant> expériences)
        {
            RecruteurId = new RecruteurId();
            Nom = nom;
            Expériences = expériences;
        }

        public override bool Equals(object obj)
        {
            return obj is Recruteur recruteur && RecruteurId.Equals(recruteur.RecruteurId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RecruteurId, Nom);
        }
    }
}
