﻿using System;
using System.Collections.Generic;
using DDD.Models.Entretien.Participant.Atout;

namespace DDD.Models.Entretien.Participant.Candidat
{
    public class Candidat
    {
        public readonly CandidatId CandidatId;
        public readonly string Nom;
        public readonly List<ExperienceParticipant> ListeExpériences;

        public Candidat(string nom, List<ExperienceParticipant> listeExpériences)
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