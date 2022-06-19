using Api.SharedKernel.Interfaces;
using System;

namespace Api.Domain.Entities
{
    public class Lead : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public LeadStatus LeadStatus { get; set; }
    }
}
