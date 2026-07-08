namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for file name values.
/// </summary>
public static class FileNameRules
{
    public const int MaximumWindowsFileNameLength = 255;

    private static readonly HashSet<string> ReservedWindowsNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "CON", "PRN", "AUX", "NUL",
        "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
        "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
    };

    public static bool IsValid(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var fileName = value.Trim();

        if (fileName.Length > MaximumWindowsFileNameLength || fileName.EndsWith('.') || fileName.EndsWith(' '))
        {
            return false;
        }

        if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
        {
            return false;
        }

        var nameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

        return !ReservedWindowsNames.Contains(nameWithoutExtension);
    }

    public static string Normalize(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        return value.Trim();
    }
}
