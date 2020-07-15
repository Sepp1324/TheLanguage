using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing
{
    public abstract class SyntaxDefinition
    {
        public string Name { get; private set; }

        public SyntaxDefinition(string name) => Name = name;

        public override string ToString() => Name;

        public abstract bool Check(List<Token> tokens, int pos, int length);
    }
}