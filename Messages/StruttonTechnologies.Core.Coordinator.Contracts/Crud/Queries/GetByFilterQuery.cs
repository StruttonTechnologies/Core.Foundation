using System.Linq.Expressions;

namespace StruttonTechnologies.Core.Coordinator.Contracts.Crud.Queries;

/// <summary>
/// Query for retrieving DTOs by filter with optional sorting, pagination, batching, and includes.
/// </summary>
/// <typeparam name="TDto">The DTO type to return.</typeparam>
/// <typeparam name="TKey">The type used for ordering expressions.</typeparam>
public record GetByFilterQuery<TDto, TKey>(
    Expression<Func<TDto, bool>>? Filter = null,
    bool IsSorted = false,
    Expression<Func<TDto, TKey>>? OrderBy = null,
    bool Ascending = true,
    bool IsPaginated = false,
    int PageNumber = 1,
    int PageSize = 100,
    bool IsBatched = false,
    int BatchSize = 100,
    Expression<Func<TDto, object>>[] IncludeProperties = null!
) : IRequest<IEnumerable<TDto>>
    where TDto : class
    where TKey : IEquatable<TKey>
{
    // Ensure IncludeProperties is never null
    public Expression<Func<TDto, object>>[] IncludeProperties { get; init; }
        = IncludeProperties ?? [];
}
