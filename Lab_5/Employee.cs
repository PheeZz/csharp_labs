namespace Lab_5;

public enum EmployeeRole
{
    Support,
    Manager,
    Programmer,
}

public enum Language
{
    English,
    French,
    German,
    Spanish,
    Italian,
    Russian,
    Chinese,
    Japanese,
    Korean,
}

public class Employee
{
    private string firstname { get; }
    private string lastname { get; }
    private string? email { get; }
    private string? phone { get; }
    private EmployeeRole role { get; }
    private List<Language> languages { get; }

    public Employee(
        string firstname,
        string lastname,
        //  email and phone can be null
        string? email,
        string? phone,
        EmployeeRole role,
        List<Language> languages
    )
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.phone = phone;
        this.role = role;
        this.languages = languages;
    }

    private static string get_languages_count(List<Language> language)
    {
        return language.Count switch
        {
            1 => "один язык",
            2 => "два языка",
            3 => "три языка",
            4 => "четыре языка",
            5 => "пять языков",
            6 => "шесть языков",
            7 => "семь языков",
            8 => "восемь языков",
            9 => "девять языков",
            10 => "десять языков",
            _ => "Unknown",
        };
    }

    private static string get_role(EmployeeRole role)
    {
        return role switch
        {
            EmployeeRole.Support => "Поддержка",
            EmployeeRole.Manager => "Менеджер",
            EmployeeRole.Programmer => "Программист",
            _ => "Unknown",
        };
    }

    public string report()
    {
        string _report = $"Сотрудник: {firstname} {lastname}\n";
        if (email != null)
        {
            _report += $"email: {email}\n";
        }
        if (phone != null)
        {
            _report += $"phone: {phone}\n";
        }
        _report += $"{get_role(role)}, знает {get_languages_count(languages)}\n";

        return _report;
    }

    public string bilengual_and_have_email()
    {
        // create report if employee know Russian as first language and English as second language and have email
        if (languages[0] == Language.Russian && languages[1] == Language.English && email != null)
        {
            return report();
        }
        else
        {
            return "";
        }
    }
}
