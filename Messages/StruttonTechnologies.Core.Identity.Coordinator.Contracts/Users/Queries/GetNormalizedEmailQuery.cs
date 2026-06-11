using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Users.Queries;

[ExcludeFromCodeCoverage]
public sealed record GetNormalizedEmailQuery(string UserId) : IRequest<string?>;
