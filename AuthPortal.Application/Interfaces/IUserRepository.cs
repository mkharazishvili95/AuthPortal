using AuthPortal.Application.DTOs;
using AuthPortal.Domain.Entities;

namespace AuthPortal.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> Get(Guid id);
        Task<List<User>> GetAll(int pageNumber, int pageSize);
        Task<bool> EmailExists(string email);
    }
}
