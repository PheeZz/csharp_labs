namespace Lab_2;

internal class Wall : Part
{
    public Wall(int x, int y) : base(x, y) { }

    public override void build()
    {
        base.build();
        build_part(X, Y, 4, 7, ConsoleColor.DarkGray);
        Thread.Sleep(250);
    }
}
