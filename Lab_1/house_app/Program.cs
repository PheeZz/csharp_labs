namespace project;

class Program
{
    static void Main()
    {
        Console.Clear();
        House.build();
        //следующие 2 строчки для того, чтобы "Process finish with exit code 0." не загораживал это произведение искусства
        Console.BackgroundColor = ConsoleColor.Black;
        House.WriteAt(" ", 0, 9);
    }
}
