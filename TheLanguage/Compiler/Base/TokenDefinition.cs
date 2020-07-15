using System.Text.RegularExpressions;

namespace Compiler.Base
{
    public class TokenDefinition
    {
        public string Name { get; private set; }

        public Regex Expression { get; private set; }

        public TokenDefinition(string name, string pattern)
        {
            Name = name;
            Expression = new Regex(pattern);
        }
    }
}
