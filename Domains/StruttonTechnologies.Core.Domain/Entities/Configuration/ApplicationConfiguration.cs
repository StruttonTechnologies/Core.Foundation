namespace StruttonTechnologies.Core.Domain.Entities.Configuration;

/// <summary>
/// Represents the default application configuration entity.
/// </summary>
/// <remarks>
/// This class provides a ready-to-use implementation of
/// <see cref="ApplicationConfigurationBase{TKey}"/> using
/// a <see cref="Guid"/> as the primary key type.
///
/// Applications that require additional configuration fields
/// may create their own configuration entity by inheriting
/// from <see cref="ApplicationConfigurationBase{TKey}"/>.
/// </remarks>
public class ApplicationConfiguration : ApplicationConfigurationBase<Guid>
{
}