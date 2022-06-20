using MediatR;

namespace LeadApi.Application.Queries
{
    public class GetAllLeadsQuerieHandler : IRequestHandler<GetAllLeadsFilter, GetAllLeadsResult>
    {
        public Task<GetAllLeadsResult> Handle(GetAllLeadsFilter request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
