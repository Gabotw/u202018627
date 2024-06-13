namespace si730pc2u202018627.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}