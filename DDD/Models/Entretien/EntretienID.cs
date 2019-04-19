﻿using System;

namespace DDD.Models.Entretien
{
    public class EntretienId
    {
        public readonly Guid Id;

        public EntretienId()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            return obj is EntretienId id && Id.Equals(id.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
