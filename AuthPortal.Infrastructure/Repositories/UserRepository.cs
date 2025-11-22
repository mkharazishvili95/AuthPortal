using AuthPortal.Application.Interfaces;
using AuthPortal.Domain.Entities;
using AuthPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthPortal.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> EmailExists(string email) => await _db.Users.AnyAsync(x => x.Email.ToUpper() == email.ToUpper());

        public async Task<User?> Get(Guid id)
        {
            return await _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> GetAll(int pageNumber = 1, int pageSize = 10)
        {
            return await _db.Users
                .AsNoTracking()
                .OrderByDescending(x => x.RegisterDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
