using Internals;

namespace NugetExample
{
    public class StringTools
    {
        public string ToUpper(string input)
        {
            var i = new SomeInternals();
            return i.ToUpperInvariant(input);
        }
    }
}
