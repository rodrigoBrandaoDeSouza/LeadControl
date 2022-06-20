using MediatR;

namespace LeadApi.Application.Queries
{
    public class GetAllLeadsFilter : IRequest<GetAllLeadsResult>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
