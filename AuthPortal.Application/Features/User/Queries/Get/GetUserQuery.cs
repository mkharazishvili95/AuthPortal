using MediatR;

namespace AuthPortal.Application.Features.User.Queries.Get
{
    public class GetUserQuery : IRequest<GetUserResponse>
    {
        public Guid Id { get; set; }
    }
}
