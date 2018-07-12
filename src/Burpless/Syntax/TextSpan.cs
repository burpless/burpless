namespace Burpless.Syntax
{
    public struct TextSpan
    {
        public TextSpan(int start, int length)
        {
            Start = start;
            Length = length;
        }

        public int Start { get; }

        public int End => Start + Length;

        public int Length { get; }

        public override string ToString()
        {
            return $"[{Start}..{End})";
        }
    }
}
