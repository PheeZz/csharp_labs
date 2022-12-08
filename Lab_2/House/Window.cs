namespace Lab_2;

internal class Window : Part
{
    public Window(int x, int y) : base(x, y) { }

    public override void build()
    {
        base.build();
        build_part(X, Y, 2, 2, ConsoleColor.Cyan);
        Thread.Sleep(250);

    }
}
