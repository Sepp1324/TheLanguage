using Compiler.Scanning;
using System.Collections.Generic;

namespace Compiler.Parsing
{
    public class SyntaxNodeDefinition
    {
        private readonly string[] tokens;

        public string Name { get; private set; }

        public SyntaxNodeDefinition(string name, params string[] tokens)
        {
            Name = name;
            this.tokens = tokens;
        }

        public override string ToString()
        {
            return Name;
        }

        public bool Check(List<Token> tokens)
        {
            for (int i = 0; i < this.tokens.Length; i++)
            {
                if (tokens[i].Name != this.tokens[i])
                    return false;
            }
            return true;
        }
    }
}