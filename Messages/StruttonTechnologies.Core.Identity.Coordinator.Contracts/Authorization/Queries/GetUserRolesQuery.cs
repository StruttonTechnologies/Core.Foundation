using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authorization.Queries;

[ExcludeFromCodeCoverage]
public sealed record GetUserRolesQuery(string UserId)
 : IRequest<IList<string>>;
