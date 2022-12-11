namespace Lab_3;

static class Program
{
    private const string exception_message = "something went wrong, error occurred";

    public static void Main(string[] args)
    {
        var file = new Json_service<string>("secret.json");
        string current_file = read_key(file);
        update_key(file, current_file + "not so secret");
        Console.WriteLine($"[SUCCESS] --- Read file: {current_file}.");
    }

    private static string read_key(ISettingsService<string> file)
    {
        try
        {
            return file.Read() ?? exception_message;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"[FAILED] --- Read file: {e.Message}");
            return exception_message;
        }
    }

    private static void update_key(ISettingsService<string> file, string item)
    {
        try
        {
            file.Update(item);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"[FAILED] --- update key: {e.Message}");
            throw;
        }
    }
}
