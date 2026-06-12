using StruttonTechnologies.Core.Domain.Entities.Base;

namespace StruttonTechnologies.Core.Domain.Entities;

/// <summary>
/// Represents a person entity in the system.
/// </summary>
/// <typeparam name="TKey">The entity key type.</typeparam>
/// <remarks>
/// This class extends <see cref="EntityBase{TKey}"/> with common
/// person-related properties such as name, contact information, and address.
/// Applications may use this class directly or inherit from it to create custom person entities.
/// </remarks>
public class Person<TKey> : EntityBase<TKey>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Gets or sets the person's first name.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the person's last name.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the person's middle name.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the person's email address.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the person's phone number.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the first line of the person's address.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the city portion of the person's address.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the state or region portion of the person's address.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the postal or ZIP code portion of the person's address.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the person is active.
    /// </summary>
    /// <remarks>
    /// This is separate from soft delete. A person may remain active or inactive
    /// while still existing as a valid business record.
    /// </remarks>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Gets the person's full name.
    /// </summary>
    /// <remarks>
    /// If <see cref="MiddleName"/> is not provided, the full name is composed
    /// from the first and last name only.
    /// </remarks>
    public string FullName => string.IsNullOrWhiteSpace(MiddleName)
        ? $"{FirstName} {LastName}"
        : $"{FirstName} {MiddleName} {LastName}";
}
