using Api.SharedKernel;
using Api.SharedKernel.Interfaces;
using MediatR;
using System.Collections.Generic;

namespace Api.Domain.Queries
{
    public class GetMessagesFilter : IRequest<List<GetMessagesResult>>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public string Login { get; set; }
    }
}
