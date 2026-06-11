using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Dtos.Navigation;

[ExcludeFromCodeCoverage]
public class SideNavDto
{
    public Guid Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string IconCss { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public bool IsActive { get; set; } = true;
}
