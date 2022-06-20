using MediatR;

namespace LeadAPI.Domain.Commands.LeadStatus
{
    public class CreateLeadStatusCommand : IRequest<Entitites.LeadStatus>
    {
        public Guid LeadId { get; set; }
        public string Status { get; set; }
    }
}