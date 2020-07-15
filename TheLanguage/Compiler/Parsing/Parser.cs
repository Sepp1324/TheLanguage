using Compiler.Scanning;
using System;
using System.Collections.Generic;

namespace Compiler.Parsing
{
    public class Parser
    {
        public List<SyntaxNodeDefinition> Definitions { get; }

        public Parser(List<SyntaxNodeDefinition> definitions)
        {
            Definitions = definitions;
        }

        public SyntaxTree Parse(List<Token> tokens)
        {
            SyntaxTree tree = new SyntaxTree();

            foreach (var definition in Definitions)
            {
                if (definition.Check(tokens))
                    Console.WriteLine($"{definition} gefunden");
            }
            return tree;
        }
    }
}