namespace Shared.Utilities;

public static class DateUtilities
{
    public static string ToIsoDate(DateTime date) => date.ToString("yyyy-MM-dd");
}
