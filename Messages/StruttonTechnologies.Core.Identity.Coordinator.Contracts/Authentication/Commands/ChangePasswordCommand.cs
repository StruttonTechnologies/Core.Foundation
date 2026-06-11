using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

[ExcludeFromCodeCoverage]
public sealed record ChangePasswordCommand(string UserId, string CurrentPassword, string NewPassword)
 : IRequest<IdentityResult>;
