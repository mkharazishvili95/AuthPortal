using AuthPortal.Application.Interfaces;
using MediatR;

namespace AuthPortal.Application.Features.User.Queries.Get
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, GetUserResponse>
    {
        readonly IUserRepository _userRepository;
        public GetUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(request.Id);

            if (user == null)
                return new GetUserResponse { Success = false, StatusCode = 404, Message = "User not found." };

            return new GetUserResponse
            {
                StatusCode = 200,
                Success = true,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Type = user.Type,
                DateOfBirth = user.DateOfBirth,
                Balance = user.Balance,
                IdentityNumber = user.IdentityNumber,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                Gender = user.Gender,
                RegisterDate = user.RegisterDate
            };
        }
    }
}
