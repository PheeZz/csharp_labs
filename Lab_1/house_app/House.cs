namespace project;

public class House
{
    protected static int shift_height;
    protected static int shift_lenght;

    static void cursor_shift()
    {
        Console.Write($"Enter the X cursor shift: ");
        shift_lenght = Int32.TryParse(Console.ReadLine(), out shift_lenght) ? shift_lenght : 5;

        Console.Write($"Enter the Y cursor shift: ");
        shift_height = Int32.TryParse(Console.ReadLine(), out shift_height) ? shift_height : 5;

        Console.Clear();
    }

    public static void build()
    {
        cursor_shift();
        roof();
        pipe();
        wall();
        door();
        window();
    }

    static void roof()
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        // left half of the roof
        WriteAt("   ", 5, 0);
        WriteAt("    ", 4, 1);
        WriteAt("     ", 3, 2);
        WriteAt("      ", 2, 3);
        WriteAt("       ", 1, 4);
        //left anchor outside
        WriteAt(" ", 0, 4);
        // right half of the roof
        WriteAt("   ", 6, 1);
        WriteAt("    ", 6, 2);
        WriteAt("     ", 6, 3);
        WriteAt("      ", 6, 4);
        //right anchor outside
        WriteAt(" ", 12, 4);
    }

    static void pipe()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        WriteAt("  ", 2, 1);
        WriteAt("  ", 2, 2);
        // smoke
        Console.BackgroundColor = ConsoleColor.DarkGray;
        WriteAt(" ", 2, 0);
    }

    static void wall()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        WriteAt("           ", 1, 5);
        WriteAt("           ", 1, 6);
        WriteAt("           ", 1, 7);
        WriteAt("           ", 1, 8);
    }

    static void door()
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        WriteAt("   ", 4, 7);
        WriteAt("   ", 4, 8);
    }

    static void window()
    {
        Console.BackgroundColor = ConsoleColor.White;
        WriteAt("   ", 8, 6);
    }

    public static void WriteAt(string line, int original_lenght, int original_height)
    {
        Console.SetCursorPosition(original_lenght + shift_lenght, original_height + shift_height);
        Console.Write(line);
    }
}
