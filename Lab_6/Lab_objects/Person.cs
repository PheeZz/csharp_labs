namespace Lab_6;

// dotnet add package Faker.Net
public enum Gender
{
    Male,
    Female,
    Other,
    Null
}

public enum Occupation
{
    Student,
    Employee,
    Retired,
    Unemployed
}

public enum Language
{
    English,
    Russian,
    German,
    French,
    Spanish,
    Italian,
    Chinese,
    Japanese,
    Korean
}

public class Person
{
    public readonly string FirstName;
    public readonly string SecondName;
    public readonly DateTime DateOfBirth;
    public readonly Gender Gender;
    public readonly List<Language> Languages;
    public readonly Occupation Occupation;

    public Person(
        string first_name,
        string second_name,
        DateTime date_of_birth,
        Gender gender,
        List<Language> languages,
        Occupation occupation
    )
    {
        FirstName = first_name;
        SecondName = second_name;
        DateOfBirth = date_of_birth;
        Gender = gender;
        Languages = languages;
        Occupation = occupation;
    }

    //generate random person
    public static Person GenerateRandomPerson()
    {
        var languages = new List<Language>();
        var random = new Random();
        var randomLanguagesCount = random.Next(1, 4);
        for (var i = 0; i < randomLanguagesCount; i++)
        {
            languages.Add((Language)random.Next(0, 9));
        }

        return new Person(
            Faker.Name.First(),
            Faker.Name.Last(),
            //generate random date of birth w\o using Faker
            new DateTime(random.Next(1900, 2021), random.Next(1, 13), random.Next(1, 29)),
            //generate random gender from enum
            (Gender)random.Next(0, 4),
            languages,
            (Occupation)random.Next(0, 4)
        );
    }

    public override string ToString()
    {
        return $"{FirstName} {SecondName}, born at: {DateOfBirth.Day}.{DateOfBirth.Month}.{DateOfBirth.Year}, speaks: {string.Join(", ", Languages)}, is a {Occupation}";
    }
}
