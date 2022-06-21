using MediatR;

namespace LeadApi.Application.Queries
{
    public class GetAllLeadsFilter : IRequest<IEnumerable<GetAllLeadsResult>>
    {
        public int Take { get; set; }
        public int Page { get; set; }
        public string Status { get; set; }
    }
}
