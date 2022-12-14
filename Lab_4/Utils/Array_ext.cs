namespace Lab_4;

public static class Array_extention
{
    public static T[] sorted<T>(this IEnumerable<T> source, Predicate<T> predicate)
        where T : IComparable<T>
    {
        var res = source.Where(item => predicate(item)).ToArray();
        Array.Sort(res);
        return res;
    }

    public static void print_array<T>(this IEnumerable<T> source_array)
    {
        foreach (var source in source_array)
        {
            Console.Write($"{source}\n");
        }
    }
}
