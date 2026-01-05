namespace BaycraftUtils.Extensions;

public static class StringExtensions
{
    public static bool IsNumeric (this string str) => double.TryParse(str, out _);
}