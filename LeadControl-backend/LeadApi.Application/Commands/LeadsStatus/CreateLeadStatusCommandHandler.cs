using LeadApi.SharedKernel.Interfaces;
using LeadAPI.Domain.Commands.LeadStatus;
using LeadAPI.Domain.Entitites;
using MediatR;

namespace LeadApi.Application.Commands.LeadsStatus
{
    public class CreateLeadStatusCommandHandler : IRequestHandler<CreateLeadStatusCommand, LeadStatus>
    {
        private readonly IDbContext _dbContext;
        private readonly IMediator _mediator;

        public CreateLeadStatusCommandHandler(IDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<LeadStatus> Handle(CreateLeadStatusCommand request, CancellationToken cancellationToken)
        {
            var status = await GetStatusByDescription(request.Status);

            var leadStatus =  await CreateLeadStatusAsync(request, status);

            return leadStatus;

        }

        private async Task<LeadStatus> CreateLeadStatusAsync(CreateLeadStatusCommand request, Status status)
        {
            var leatStatusId = Guid.NewGuid();
            var leadStatus = new LeadStatus()
            {
                Id = leatStatusId,
                Status = status,
                LeadId = request.LeadId,
                StatusId = status.Id
            };

            await _dbContext.CreateAsync(leadStatus);

            return leadStatus;
        }

        public async Task<Status> GetStatusByDescription(string description)
        {
            return _dbContext.GetQueryable<Status>()
                .Where(x => x.Description == description)
                .FirstOrDefault() ?? new Status();
        }

    }
}
