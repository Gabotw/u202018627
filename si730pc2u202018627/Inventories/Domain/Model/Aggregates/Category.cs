using si730pc2u202018627.Inventories.Domain.Model.Commands;

namespace si730pc2u202018627.Inventories.Domain.Model.Aggregates;

public class Category
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
    
    public long GroupId { get; private set; }
    
    public string Description { get; private set; }
    
    public string ReferenceImageUrl { get; private set; }

    protected Category()
    {
        this.Name = string.Empty;
        this.GroupId = 0;
        this.Description = string.Empty;
        this.ReferenceImageUrl = string.Empty;
    }
    public Category(CreateCategoryCommand command)
    {
        this.Name = command.Name;
        this.GroupId = command.GroupId;
        this.Description = command.Description;
        this.ReferenceImageUrl = command.ReferenceImageUrl;
    }
}