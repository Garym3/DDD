using System;
using System.Collections.Generic;
using DDD.Models.Entretien.Participant.Atout;

namespace DDD.Models.Entretien.Participant.Recruteur
{
    public class Recruteur
    {
        public readonly RecruteurId RecruteurId;
        public readonly string Nom;
        public readonly List<ExperienceParticipant> ListeExpériences;

        public Recruteur(string nom, List<ExperienceParticipant> listeExpériences)
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
