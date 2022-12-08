namespace Lab_2;

internal interface IPart
{
    void build();

    // Rectangle DrawRectangle();
    void build_part(int x, int y, int width, int height, ConsoleColor color);
    bool is_builded { get; set; }
}

// Abstraction in C# is the process to hide the internal details and show only the functionality
public abstract class Part : IPart
{
    protected readonly int X;
    protected readonly int Y;
    public bool is_builded { get; set; }

    protected Part(int x, int y)
    {
        X = x;
        Y = y;
    }

    // virtual = available to override(expand)
    public virtual void build()
    {
        is_builded = true;
    }

    public void build_part(int x, int y, int width, int height, ConsoleColor color)
    {
        x = x + 2;
        Console.BackgroundColor = color;
        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                Console.SetCursorPosition(x + j, y + i);
                Console.Write(" ");
            }
        }
    }
}
