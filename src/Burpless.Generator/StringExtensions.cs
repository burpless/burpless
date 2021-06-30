namespace Burpless.Generator
{
    public static class StringExtensions
    {
        public static string AsQuoted(this string value)
        {
            return $"\"{value}\"";
        }
    }
}
