﻿using System.Text.RegularExpressions;

namespace Compiler.Base
{
    public class Token
    {
        public string Name { get; private set; }

        public int Position { get; private set; }

        public int Length { get; private set; }

        public string Value { get; private set; }

        public TokenDefinition Definition { get; set; }

        public Token(Match result, TokenDefinition definition)
        {
            Value = result.Value;
            Name = definition.Name;
            Position = result.Index;
            Length = result.Length;
            Definition = definition;
        }

        public override string ToString() => $"{Name} [{Value}]";
    }
}
