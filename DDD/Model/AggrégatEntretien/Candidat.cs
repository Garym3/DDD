using System;
using System.Collections.Generic;

namespace DDD.Model.AggrégatEntretien
{
    internal class Candidat
    {
        public readonly CandidatId CandidatId;
        public readonly string Nom;
        public readonly List<ExpérienceParticipant> ListeExpériences;

        public Candidat(string nom, List<ExpérienceParticipant> listeExpériences)
        {
            CandidatId = new CandidatId();
            Nom = nom;
            ListeExpériences = listeExpériences;
        }

        public override bool Equals(object obj)
        {
            return obj is Candidat candidat && CandidatId.Equals(candidat.CandidatId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CandidatId, Nom);
        }
    }
}
