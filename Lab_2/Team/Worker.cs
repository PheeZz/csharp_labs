namespace Lab_2;

internal class Worker
{
    internal Part Part { get; set; }

    public Worker(Part part)
    {
        Part = part;
    }

    public void build_part()
    {
        Part.build();
    }
}
