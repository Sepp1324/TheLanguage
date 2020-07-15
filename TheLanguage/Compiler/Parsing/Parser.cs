using Compiler.Parsing.Definition;
using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing
{
    public class Parser
    {
        public Parser()
        {
        }

        public SyntaxTree Parse(List<Token> tokens)
        {
            SyntaxTree tree = new SyntaxTree();

            ExpressionSyntaxDefinition expressions = new ExpressionSyntaxDefinition();
            expressions.Check(tokens, 0, tokens.Count);

            return tree;
        }
    }
}