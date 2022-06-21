using LeadApi.SharedKernel.Interfaces;
using LeadAPI.Domain.Commands.Lead;
using LeadAPI.Domain.Entitites;
using MediatR;

namespace LeadApi.Application.Commands.Leads
{
    public class UpdateLeadCommandHandler : IRequestHandler<UpdateLeadCommand, string>
    {
        private readonly IDbContext _dbContext;
        private readonly IMediator _mediator;

        public UpdateLeadCommandHandler(IDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<string> Handle(UpdateLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = _dbContext.GetQueryable<Lead>()
                 .Where(x => x.Id.ToString() == request.LeadId)
                 .FirstOrDefault();

            var status = _dbContext.GetQueryable<Status>()
                .Where(x => x.Description == request.Status)
                .FirstOrDefault();

            var leadStatus = _dbContext.GetQueryable<LeadStatus>()
                .Where(x => x.Lead.Id == lead.Id)
                .FirstOrDefault();
            
            lead = ValidateLeadDiscount(lead);

            if (status != null && leadStatus != null && status != null)
            {
                leadStatus.Status = status;

                await _dbContext.UpdateAsync(leadStatus);
            }

            await _dbContext.CommitTransactionAsync();

            return $"{lead.Id}-{status.Description}";
        }

        private Lead ValidateLeadDiscount(Lead? lead)
        {
            if (lead.Price >= 500)
            {
                lead.Price = Convert.ToDecimal(Convert.ToDouble(lead.Price) * 0.9);
            }
            return lead;
        }
    }
}
