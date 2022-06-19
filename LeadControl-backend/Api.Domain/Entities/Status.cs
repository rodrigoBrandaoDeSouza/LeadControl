using Api.SharedKernel.Interfaces;
using System;

namespace Api.Domain.Entities
{
    public class Status : IEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public LeadStatus LeadStatus { get; set; }
    }
}
