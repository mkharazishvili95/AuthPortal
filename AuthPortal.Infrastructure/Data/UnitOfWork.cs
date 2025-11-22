using AuthPortal.Application.Interfaces;

namespace AuthPortal.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> SaveChangesAsync() => await _db.SaveChangesAsync(); 
    }
}
