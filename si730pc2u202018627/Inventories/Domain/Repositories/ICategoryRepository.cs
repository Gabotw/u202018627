using si730pc2u202018627.Inventories.Domain.Model.Aggregates;
using si730pc2u202018627.Shared.Domain.Repositories;

namespace si730pc2u202018627.Inventories.Domain.Repositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<IEnumerable<Category>> FindAllCategoryAsync(string categoryName);
}