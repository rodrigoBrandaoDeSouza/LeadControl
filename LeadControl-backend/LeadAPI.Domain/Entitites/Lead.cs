﻿namespace LeadAPI.Domain.Entitites
{
    public class Lead
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public string JobId { get; set; }
        public decimal Price { get; set; }
        public LeadStatus LeadStatus { get; set; }
    }
}
