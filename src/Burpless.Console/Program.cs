using System;
using System.Linq;
using System.Reflection;
using Burpless.Configuration;
using Burpless.Parsing;
using Burpless.Syntax.Keywords;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace Burpless.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string value = @"
Feature: This is my feature
         With a feature description

# Comment about things here

@tag
Scenario: When things happen
  Given a thing happens
  When I do something
  Then there is a reaction";

            const string code = @"

class SimpleClass
{ // comment
    public void SimpleMethod()
    {
        var myName = '';
    }
}";

            var dialect = Dialect.Default;

            var grammar = new KeywordGrammarBuilder(dialect)
                .Build();

            var options = CSharpParseOptions.Default;

            var type = typeof(CSharpParseOptions).Assembly.GetType("Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer");
            var method = type.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(x => x.Name == "Lex")
                .FirstOrDefault(x => x.GetParameters().All(y => !y.ParameterType.IsByRef));

            var lexer = type.GetConstructors().First()
                .Invoke(new object[] {SourceText.From(code), options, true, false});

            while (true)
            {
                var syntaxToken = method.Invoke(lexer, new object[] {1});
            }
            
            var tree = CSharpSyntaxTree.ParseText(value);
            var root = tree.GetRoot();

            var reader = new TokenReader(value);

            var token = TokenType.Whitespace;
            var lastPosition = 0;

            while (token != TokenType.EndOfFile)
            {
                token = reader.Read();
                var str = value.Substring(lastPosition, reader.Position - lastPosition);

                lastPosition = reader.Position;
            }
        }
    }
}
