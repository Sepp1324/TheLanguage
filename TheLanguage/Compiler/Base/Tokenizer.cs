﻿using System;
using System.Collections.Generic;

namespace Compiler.Base
{
    public class Tokenizer
    {
        public List<TokenDefinition> Definitions { get; private set; }

        public Tokenizer(List<TokenDefinition> definitions)
        {
            Definitions = definitions;
        }

        public List<Token> Parse(string input)
        {
            var list = new List<Token>();

            for (int i = 0; i < input.Length;)
            {
                bool isSuccess = false;

                foreach (var definition in Definitions)
                {
                    var result = definition.Expression.Match(input, i);

                    if (!result.Success || i != result.Index)
                        continue;

                    isSuccess = true;

                    i += result.Length;

                    if (!definition.Skip)
                        list.Add(new Token(result, definition));
                    break;
                }

                if (!isSuccess)
                    throw new Exception("Invalid Expression (Tokenizer (Line: 38))");
            }
            return list;
        }
    }
}
