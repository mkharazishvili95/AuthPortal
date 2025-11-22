using AuthPortal.Application.Interfaces;
using AuthPortal.Infrastructure.Data;

namespace AuthPortal.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        readonly ApplicationDbContext _db;
        public AuthRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
