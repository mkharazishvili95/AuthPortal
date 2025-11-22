using AuthPortal.Domain.Enums;

namespace AuthPortal.Application.DTOs
{
    public class UserDto
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
        public bool IsBlocked { get; set; }
        public DateTime? BlockDate { get; set; }
    }
}
