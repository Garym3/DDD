using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Commun.Dto
{
    public class RecruteurDto
    {
        public string Nom { get; set; }
        public List<ExpérienceParticipantDto> Expériences;

        public RecruteurDto(string nom, List<ExpérienceParticipantDto> expériences)
        {
            Nom = nom;
            Expériences = expériences;
        }
    }
}
