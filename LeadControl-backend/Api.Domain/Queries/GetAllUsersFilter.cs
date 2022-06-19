using MediatR;
using System.Collections.Generic;

namespace Api.Domain.Queries
{
    public class GetAllUsersFilter : IRequest<List<GetAllUsersResult>>
    {
        public string Login { get; set; }

        public GetAllUsersFilter(string login)
        {
            Login = login;
        }
    }


}
