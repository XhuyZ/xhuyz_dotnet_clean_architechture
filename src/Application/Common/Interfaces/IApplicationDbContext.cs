using xhuyz_dotnet_clean_architechture.Domain.Entities;

namespace xhuyz_dotnet_clean_architechture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
