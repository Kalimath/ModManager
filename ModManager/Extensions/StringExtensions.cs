namespace ModManager.Extensions;

public static class StringExtensions
{
    public static string TrimModName(this string value, string prefixEnd)
    {
        var withoutPrefix = value.Split(prefixEnd, StringSplitOptions.RemoveEmptyEntries)[1];
        var trailing = ".zip";
        return withoutPrefix.Remove(withoutPrefix.Length - trailing.Length,trailing.Length);
    }
}