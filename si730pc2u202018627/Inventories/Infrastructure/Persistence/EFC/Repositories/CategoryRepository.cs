using CatchUpPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u202018627.Inventories.Domain.Model.Aggregates;
using si730pc2u202018627.Inventories.Domain.Repositories;
using si730pc2u202018627.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace si730pc2u202018627.Inventories.Infrastructure.Persistence.EFC.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Category>> FindAllCategoryAsync(string categoryName)
    {
        
    }
}