using System.Collections.Generic;
using System.Linq;

namespace Burpless.Generator
{
    public static class EnumerableExtensions
    {
        public static string JoinQuoted(this IEnumerable<string> source, string separator)
        {
            var values = source.Select(x => x.AsQuoted());

            return string.Join(separator, values);
        }
    }
}
