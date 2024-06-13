using si730pc2u202018627.Shared.Domain.Repositories;
using si730pc2u202018627.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace CatchUpPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}