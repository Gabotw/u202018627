using si730pc2u202018627.Inventories.Domain.Model.Aggregates;
using si730pc2u202018627.Inventories.Domain.Model.Commands;
using si730pc2u202018627.Inventories.Domain.Repositories;
using si730pc2u202018627.Inventories.Domain.Services;
using si730pc2u202018627.Shared.Domain.Repositories;

namespace si730pc2u202018627.Inventories.Application.Internal.CommandServices;

public class CategoryCommandService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : ICategoryCommandService
{
    public async Task<Category> Handle(CreateCategoryCommand command)
    {
        var category = await categoryRepository.FindAllCategoryAsync(command);
        if (category != null)
            throw new Exception("Category with this CategoryName already exists");
        category = new Category(command);
        await categoryRepository.AddAsync(category);
        await unitOfWork.CompleteAsync();
        return category;
    }
}
 