namespace Burpless.Parsing
{
    public enum TokenType
    {
        NewLine,
        Whitespace,
        Text,
        Comment,
        Colon,
        Table,
        Tag,
        OpenParameter,
        CloseParameter,
        DocString,
        EndOfFile
    }
}
