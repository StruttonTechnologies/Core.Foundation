using System.Linq.Expressions;

namespace StruttonTechnologies.Core.Coordinator.Contracts.Crud.Queries;

/// <summary>
/// Query to retrieve DTOs with optional sorting, filtering, batching, and pagination.
/// </summary>
/// <typeparam name="TDto">The DTO type to return.</typeparam>
public record GetAllQuery<TDto>(
    bool IsSorted = true,
    Expression<Func<TDto, object>>? OrderBy = null,
    bool Ascending = true,
    bool IsPaginated = true,
    int PageNumber = 1,
    int PageSize = 100,
    bool IsBatched = true,
    int BatchSize = 100,
    Expression<Func<TDto, bool>>? Filter = null
) : IRequest<IEnumerable<TDto>>
    where TDto : class;

