namespace Lab_2;

internal class Team_leader
{
    private Building Building { get; }

    public Team_leader(Building building)
    {
        Building = building;
    }

    public void report()
    {
        Console.ResetColor();
        if (Building.besement_builded())
        {
            Console.WriteLine("The basement is built");
        }

        if (Building.door_installed())
        {
            Console.WriteLine("The door is built");
        }

        if (Building.roof_builded())
        {
            Console.WriteLine("The roof is built");
        }

        if (Building.walls_builded())
        {
            Console.WriteLine("The walls is built");
        }

        if (Building.windows_installed())
        {
            Console.WriteLine("The windows is built");
        }
    }
}
