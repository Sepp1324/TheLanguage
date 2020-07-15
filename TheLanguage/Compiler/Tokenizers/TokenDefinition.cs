using System.Text.RegularExpressions;

namespace Compiler.Tokenizers
{
    public class TokenDefinition
    {
        public string Name { get; set; }

        public Regex Expression { get; set; }
    }
}
