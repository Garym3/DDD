using System;
using System.Collections.Generic;
using System.Text;
using DDD.Model.AggrégatEntretien;

namespace DDD.Commun.Dto
{
    public class CandidatDto
    {
        public string Nom { get; set; }
        public List<ExpérienceParticipantDto> Expériences { get; set; }

        public CandidatDto(string nom, List<ExpérienceParticipantDto> expériences)
        {
            Nom = nom;
            Expériences = expériences;
        }
    }
}
