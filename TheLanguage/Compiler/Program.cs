using Compiler.Base;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1 + 1";

            TokenDefinition integerDefinition = new TokenDefinition("Integer", "[0-9]+");
            TokenDefinition spaceDefinition = new TokenDefinition("Space", " ");
            TokenDefinition plusDefinition = new TokenDefinition("Plus", "+");
        }
    }
}
