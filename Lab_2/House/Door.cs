namespace Lab_2;

internal class Door : Part
{
    public Door(int x, int y) : base(x, y) { }

    public override void build()
    {
        base.build();
        build_part(X, Y, 5, 4, ConsoleColor.DarkMagenta);
        Thread.Sleep(500);
    }
}
