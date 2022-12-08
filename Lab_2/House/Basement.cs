namespace Lab_2;

internal class Basement : Part
{
    public Basement(int x, int y) : base(x, y) { }

    public override void build()
    {
        base.build();
        build_part(0, Y, 16, 1, ConsoleColor.DarkBlue);
        Thread.Sleep(1000);

    }
}
