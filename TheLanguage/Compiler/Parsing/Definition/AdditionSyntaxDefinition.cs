using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing.Definition
{
    public class AdditionSyntaxDefinition : SyntaxDefinition
    {
        public AdditionSyntaxDefinition() : base(nameof(AdditionSyntaxDefinition))
        {
        }

        public override bool Check(List<Token> tokens, int pos, int length)
        {
            for (int i = pos; i < length; i++)
            {
                if (tokens[i].Name == "Plus")
                {
                    var left = new IntegerSyntaxDefinition();
                    var right = new IntegerSyntaxDefinition();

                    if (left.Check(tokens, pos, i) && right.Check(tokens, i + 1, length - i - 1))
                        return true;
                }
            }
            return false;
        }
    }
}