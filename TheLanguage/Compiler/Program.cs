using Compiler.Base;
using System.Collections.Generic;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1 + 1";

            var definitions = new List<TokenDefinition>()
            {
                new TokenDefinition("Integer", "[0-9]+"),
                new TokenDefinition("Space", " ", true),
                new TokenDefinition("Plus", "[+]")
            };

            var tokenizer = new Tokenizer(definitions);

            var result = tokenizer.Parse(input);
        }
    }
}
