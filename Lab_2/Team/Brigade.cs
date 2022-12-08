namespace Lab_2;

internal class Brigade
{
    private readonly Team_leader _team_leader;
    private readonly List<Worker>? _workers;
    private readonly Building _building;

    public Brigade()
    {
        _building = new Building(0, 0);
        _team_leader = new Team_leader(_building);
        _workers = new List<Worker>
        {
            new(_building.Basement),
            new(_building.Door),
            new(_building.Roof)
        };
        foreach (var wall in _building.Walls)
        {
            _workers.Add(new Worker(wall));
        }
        foreach (var window in _building.Windows)
        {
            _workers.Add(new Worker(window));
        }
    }

    private void Build<T>()
    {
        _workers?.Find(w => w.Part is T && w.Part.is_builded == false)?.build_part();
    }

    public void build_house(int x, int y)
    {
        while (!_building.besement_builded())
        {
            Build<Basement>();
        }
        while (!_building.walls_builded())
        {
            Build<Wall>();
        }
        while (!_building.roof_builded())
        {
            Build<Roof>();
        }
        while (!_building.door_installed())
        {
            Build<Door>();
        }
        while (!_building.windows_installed())
        {
            Build<Window>();
        }
        Console.SetCursorPosition(0, y + 16);
        _team_leader.report();
    }
}
