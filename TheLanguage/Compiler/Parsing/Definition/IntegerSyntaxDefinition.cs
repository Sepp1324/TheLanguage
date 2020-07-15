using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing.Definition
{
    public class IntegerSyntaxDefinition : SyntaxDefinition
    {
        public int Value { get; set; }

        public IntegerSyntaxDefinition() : base(nameof(IntegerSyntaxDefinition))
        {
        }

        public override bool Check(List<Token> tokens, int pos, int length)
        {
            if (tokens[pos].Name == "Integer")
            {
                Value = int.Parse(tokens[pos].Value);
                return true;
            }
            return false;
        }
    }
}