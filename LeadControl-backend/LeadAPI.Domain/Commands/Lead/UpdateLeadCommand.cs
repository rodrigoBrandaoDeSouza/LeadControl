using MediatR;
using System.Text.Json.Serialization;

namespace LeadAPI.Domain.Commands.Lead
{
    public class UpdateLeadCommand : IRequest<string>
    {
        [JsonPropertyName("leadId")]
        public string LeadId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}