namespace Burpless;

public class Table
{
    public Table(params string[] columns)
    {
    }

    public Table AddRow(params string[] items)
    {
        return this;
    }
}
