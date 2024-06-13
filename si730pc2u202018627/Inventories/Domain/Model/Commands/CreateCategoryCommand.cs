namespace si730pc2u202018627.Inventories.Domain.Model.Commands;

public record CreateCategoryCommand(string Name, long GroupId, string Description, string ReferenceImageUrl);