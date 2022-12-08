namespace Lab_2;

internal class Roof : Part
{
    public Roof(int x, int y) : base(x, y) { }

    public override void build()
    {
        base.build();
        Console.ForegroundColor = ConsoleColor.Gray;
        for (var i = 8; i >= 0; i--)
        {
            build_part(X + (8 - i), Y + i, i * 2, 1, ConsoleColor.Gray);
            Console.WriteLine();
            Thread.Sleep(250);
        }
    }
}
