using si730pc2u202018627.Inventories.Domain.Model.Aggregates;
using si730pc2u202018627.Inventories.Domain.Model.Commands;

namespace si730pc2u202018627.Inventories.Domain.Services;

public interface ICategoryCommandService
{
    Task<Category> Handle(CreateCategoryCommand command);
}