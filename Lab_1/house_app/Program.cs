namespace project;

class Program
{
    static void Main()
    {
        Console.Clear();
        House.build();

        //prettyfier
        Console.BackgroundColor = ConsoleColor.Black;
        House.WriteAt(" ", 0, 9);
    }
}
