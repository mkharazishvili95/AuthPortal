using AuthPortal.Application.Commons.Models;
using AuthPortal.Domain.Enums;

namespace AuthPortal.Application.Features.User.Queries.Get
{
    public class GetUserResponse : BaseResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Type { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Balance { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public Gender? Gender { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
