using System;
using System.Collections.Generic;
using DDD.Models.Entretien.Participant.Atout;

namespace DDD.Models.Entretien.Participant.Recruteur
{
    public class Recruteur
    {
        public readonly RecruteurId RecruteurId;
        public readonly string Nom;
        public readonly List<ExpérienceParticipant> ListeExpériences;

        public Recruteur(string nom, List<ExpérienceParticipant> listeExpériences)
        {
            RecruteurId = new RecruteurId();
            Nom = nom;
            ListeExpériences = listeExpériences;
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
