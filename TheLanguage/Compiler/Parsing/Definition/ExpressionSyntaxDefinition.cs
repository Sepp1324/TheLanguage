using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing.Definition
{
    public class ExpressionSyntaxDefinition : SyntaxDefinition
    {
        public ExpressionSyntaxDefinition() : base(nameof(ExpressionSyntaxDefinition))
        {
        }

        public override bool Check(List<Token> tokens, int pos, int length)
        {
            var add = new AdditionSyntaxDefinition();
            return add.Check(tokens, pos, length);
        }
    }
}