using Api.SharedKernel.Interfaces;
using System;

namespace Api.Domain.Entities
{
    public class LeadStatus : IEntity
    {
        public Guid Id { get; set; }
        public Guid LeadId { get; set; }
        public Lead Lead{ get; set; }
        public Guid StatusId { get; set; }
        public Status Status{ get; set; }
    }
}
