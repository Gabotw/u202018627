using si730pc2u202018627.Inventories.Domain.Model.Aggregates;
using si730pc2u202018627.Inventories.Domain.Model.Queries;

namespace si730pc2u202018627.Inventories.Domain.Services;

public interface ICategoryQueryService
{
    Task<Category> Handle(GetAllCategoryQuery query);
}