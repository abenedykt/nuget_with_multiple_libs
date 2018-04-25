using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NugetExample")]

namespace Internals
{
    internal class SomeInternals
    {
        internal string ToUpperInvariant(string input)
        {
            return input.ToUpperInvariant();
        }
    }
}
