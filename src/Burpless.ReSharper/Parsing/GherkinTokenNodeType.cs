using Burpless.ReSharper.Tree;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace Burpless.ReSharper.Parsing
{
    public class GherkinTokenNodeType : TokenNodeType
    {
        public static readonly GherkinTokenNodeType Feature = new GherkinTokenNodeType("Feature", 1000, "Feature:");

        public GherkinTokenNodeType(string name, int index, string representation)
            : base(name, index)
        {
            TokenRepresentation = representation;
        }

        public override bool IsWhitespace { get; }

        public override bool IsComment => TokenRepresentation == "#";

        public override bool IsStringLiteral { get; }

        public override bool IsConstantLiteral { get; }

        public override bool IsIdentifier { get; }

        public override bool IsKeyword { get; }

        public override string TokenRepresentation { get; }

        public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        {
            return new GherkinToken(this, buffer, startOffset, endOffset);
        }
    }
}
