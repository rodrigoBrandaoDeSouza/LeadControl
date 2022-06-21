using LeadApi.SharedKernel.Interfaces;
using LeadAPI.Domain.Commands.Lead;
using LeadAPI.Domain.Commands.LeadStatus;
using LeadAPI.Domain.Entitites;
using MediatR;

namespace LeadApi.Application.Commands.Leads
{
    public class CreateLeadCommandHandler : IRequestHandler<CreateLeadCommand, Guid>
    {
        private readonly IDbContext _dbContext;
        private readonly IMediator _mediator;

        public CreateLeadCommandHandler(IDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await CreateLeadAsync(request);

            await _dbContext.SaveChangesAsync();

            await _dbContext.CommitTransactionAsync();

            return lead.Id;
        }

        private async Task<Lead> CreateLeadAsync(CreateLeadCommand request)
        {
            var leadId = Guid.NewGuid();

            var leadStatusCommand = new CreateLeadStatusCommand()
            {
                LeadId = leadId,
                Status = request.Status
            };

            var leadStatus = await _mediator.Send(leadStatusCommand);

            var lead = new Lead()
            {
                Id = leadId,
                Category = request.Category,
                Description = request.Description,
                Email = request.Email,
                DateCreated = DateTime.Now,
                Phone = request.Phone,
                JobId = request.JobId,  
                FirstName = request.FirstName,
                LastName = request.LastName,
                Price = Convert.ToDecimal(request.Price),
                Suburb = request.Sudurb,
                LeadStatus = leadStatus ?? new LeadStatus()
            };
            
            await _dbContext.CreateAsync(lead);

            return lead;
        }
    }
}
