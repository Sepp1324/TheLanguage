using Microsoft.CodeAnalysis.CSharp;
using System;

namespace RoslynTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = CSharpSyntaxTree.ParseText("");
        }
    }
}
