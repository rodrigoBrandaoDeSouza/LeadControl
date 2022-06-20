using System.Collections.Generic;

namespace LeadAPI.Domain.Entitites
{
    public class LeadStatus
    {
        public Guid Id { get; set; }
        public Guid LeadId { get; set; }
        public Lead Lead{ get; set; }
        public Guid StatusId { get; set; }
        public Status Status{ get; set; }
    }
}
