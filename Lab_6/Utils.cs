namespace Lab_6;

public static class Utils
{
    public static void Print<T>(this IEnumerable<T> array, string caption)
    {
        Console.WriteLine("");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(caption);
        Console.WriteLine("-------------------------------");

        foreach (var item in array)
            Console.WriteLine(item);
    }

    public static IQueryable<Person> ApplyFilter(
        this IEnumerable<Person> people,
        string? firstName = null,
        string? secondName = null,
        DateTime startDate = new(),
        DateTime endDate = new(),
        Gender gender = Gender.Null,
        List<Language>? languages = null,
        List<Occupation>? occupations = null
    )
    {
        var query = people.AsQueryable();
        if (firstName != null)
            query = query.Where(person => person.FirstName == firstName);

        if (secondName != null)
            query = query.Where(person => person.SecondName == secondName);

        if (startDate != new DateTime() && endDate != new DateTime())
            query = query.Where(person => person.DateOfBirth >= startDate);

        if (gender != Gender.Null)
            query = query.Where(person => person.Gender == gender);

        if (languages != null)
            query = query.Where(
                person => languages.All(language => person.Languages.Contains(language))
            );
        if (occupations != null)
            query = query.Where(
                person => occupations.All(occupation => person.Occupation == occupation)
            );

        return query;
    }

    public static IEnumerable<object> Filter<T>(
        this IEnumerable<T> array,
        Func<IEnumerable<T>, IEnumerable<object>> filter
    )
    {
        return filter(array);
    }
}
