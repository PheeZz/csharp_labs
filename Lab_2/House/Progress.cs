namespace Lab_2;

internal class Building
{
    public List<Wall> Walls { get; } = new List<Wall>();
    public List<Window> Windows { get; } = new List<Window>();
    public Roof Roof { get; }
    public Basement Basement { get; }
    public Door Door { get; }

    public Building(int x, int y)
    {
        Basement = new Basement(x + 15, y + 15);

        for (var i = 0; i < 4; i++)
        {
            Walls.Add(new Wall(x + i * 4, y + 8));
        }
        for (var i = 0; i < 4; i++)
        {
            Windows.Add(new Window(x + i + 2, y + 10));
        }

        Roof = new Roof(x, y);
        Door = new Door(x + 9, y + 11);
    }

    public bool walls_builded()
    {
        return Walls.Find(wall => wall.is_builded == false) == null;
    }

    public bool windows_installed()
    {
        return Windows.Find(window => window.is_builded == false) == null;
    }

    public bool roof_builded()
    {
        return Roof.is_builded;
    }

    public bool besement_builded()
    {
        return Basement.is_builded;
    }

    public bool door_installed()
    {
        return Door.is_builded;
    }
}
