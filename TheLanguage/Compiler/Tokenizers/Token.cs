namespace Compiler.Tokenizers
{
    public class Token
    {
        public string Name { get; set; }

        public int Position { get; set; }

        public int Length { get; set; }

        public string Value { get; set; }
    }
}
