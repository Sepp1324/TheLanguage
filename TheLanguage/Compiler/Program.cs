using Compiler.Parsing;
using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "1 + 2 + 3";

            var tokenDefinitions = new List<TokenDefinition>()
            {
                new TokenDefinition("Integer", "[0-9]+"),
                new TokenDefinition("Space", " ", true),
                new TokenDefinition("Plus", "[+]")
            };

            var syntaxNodeDefinitions = new List<SyntaxNodeDefinition>()
            {
                new SyntaxNodeDefinition("Addition", "Integer", "Plus", "Integer")
            };

            var tokenizer = new Tokenizer(tokenDefinitions);

            var tokenResult = tokenizer.Parse(input);

            var parser = new Parser(syntaxNodeDefinitions);

            var syntaxTree = parser.Parse(tokenResult);
        }
    }
}