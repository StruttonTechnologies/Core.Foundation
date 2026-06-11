using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Domain.Entities.Base;

[ExcludeFromCodeCoverage]
public class BaseNavEntity<TPerson, TKey>
    where TKey : IEquatable<TKey>
    where TPerson : Person<TKey>
{
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string IconCss { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public bool IsActive { get; set; } = true;
}
