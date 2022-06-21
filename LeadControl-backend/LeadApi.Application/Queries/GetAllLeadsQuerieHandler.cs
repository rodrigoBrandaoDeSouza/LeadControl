using LeadApi.SharedKernel.Interfaces;
using LeadAPI.Domain.Entitites;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LeadApi.Application.Queries
{

    public class GetAllLeadsQuerieHandler : IRequestHandler<GetAllLeadsFilter, IEnumerable<GetAllLeadsResult>>
    {
        private readonly IDbContext _dbContext;

        public GetAllLeadsQuerieHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetAllLeadsResult>> Handle(GetAllLeadsFilter request, CancellationToken cancellationToken)
        {
            var query = _dbContext.GetQueryable<Lead>()
                .Select(lead => new GetAllLeadsResult
                {
                    Category = lead.Category,
                    Description = lead.Description,
                    Email = lead.Email,
                    DateCreated = lead.DateCreated.ToString("MMMM d HH:mm"),
                    FullName = $"{lead.FirstName} {lead.LastName}",
                    Suburb = lead.Suburb,
                    Id = lead.Id,
                    JobId = lead.JobId,
                    Phone = lead.Phone,
                    Price = lead.Price,
                    Status = lead.LeadStatus.Status.Description
                })
                .Where( x=>x.Status == request.Status)
                .Skip((request.Page - 1) * request.Take)
                .Take(request.Take);

            return await query.ToListAsync();
        }

        public string getLeadStatus(Guid leadId)
        {
            var status = _dbContext.GetQueryable<LeadStatus>()
                .Where(x => x.Lead.Id == leadId)
                .Select(lt => lt.Status)
                .FirstOrDefault();

            return status.Description ?? String.Empty;
        }
    }
}
