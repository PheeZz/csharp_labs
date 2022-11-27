namespace project;

class Program
{
    static void Main()
    {
        read_string();
        number_int();
        number_float();
    }

    static string read_string(int max_length = 20, string field = "name")
    {
        string? answer;
        while (true)
        {
            Console.WriteLine($"Please, enter ur {field}:");
            answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine($"{field} can not be empty\n");
                continue;
            }

            if (answer.Length > max_length)
            {
                Console.WriteLine($"{field} must be shorter than {max_length} symbols\n");
                continue;
            }

            break;
        }

        return answer;
    }

    static int number_int(int max_value = 25, int min_value = 1, string field = "integer number")
    {
        string? number_readed;
        int number;
        while (true)
        {
            Console.WriteLine($"\nPlease, enter ur {field}");
            // if  Console.ReadLine() is null or empty or not a integer number continue
            if (
                string.IsNullOrEmpty(number_readed = Console.ReadLine())
                || !int.TryParse(number_readed, out number)
            )
            {
                Console.WriteLine($"{field} must be a digits value\n");
                continue;
            }
            // if number is not in range continue
            if (number > max_value || number < min_value)
            {
                Console.WriteLine($"{field} must be in range {min_value} - {max_value}\n");
                continue;
            }
            break;
        }
        return number;
    }

    static float number_float(
        float maxValue = 25.2f,
        float minValue = 1.2f,
        string field = "float number"
    )
    {
        string? number_readed;
        float number;
        while (true)
        {
            Console.WriteLine($"\nPlease, enter ur {field}");
            // if  Console.ReadLine() is null or empty or not a float number continue
            if (
                string.IsNullOrEmpty(number_readed = Console.ReadLine())
                || !float.TryParse(number_readed, out number)
            )
            {
                Console.WriteLine($"{field} must be a digits value with separator ','\n");
                continue;
            }

            if (minValue >= number || number >= maxValue)
            {
                Console.WriteLine($"{field} must be in range {minValue} - {maxValue}\n");
                continue;
            }
            break;
        }
        return number + 0.2f;
    }
}
