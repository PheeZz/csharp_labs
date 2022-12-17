namespace Lab_5;

public class Program
{
    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Employee(
                firstname: "John",
                lastname: "Doe",
                email: "corpse@gmail.com,",
                phone: "+1 234 567 89 00",
                role: EmployeeRole.Programmer,
                languages: new List<Language> { Language.English, Language.French, Language.German }
            ),
            new Employee(
                firstname: "Shadow",
                lastname: "Raze",
                email: "zxc1007@mail.ru",
                phone: "+7 800 555 35 35",
                role: EmployeeRole.Manager,
                languages: new List<Language>
                {
                    Language.Russian,
                    Language.English,
                    Language.German,
                    Language.Spanish,
                    Language.Italian
                }
            ),
            new Employee(
                firstname: "Sergey",
                lastname: "Ivanov",
                email: null,
                phone: "+7 921 123 45 67",
                role: EmployeeRole.Support,
                languages: new List<Language> { Language.Russian, Language.English }
            ),
            new Employee(
                firstname: "Ivan",
                lastname: "Petrov",
                email: "petrov@list.ru",
                phone: null,
                role: EmployeeRole.Programmer,
                languages: new List<Language>
                {
                    Language.Russian,
                    Language.English,
                    Language.Chinese,
                    Language.Japanese,
                    Language.Korean
                }
            ),
            new Employee(
                firstname: "Petr",
                lastname: "Sidorov",
                email: "psi@gmail.com",
                phone: "+7 900 123 45 67",
                role: EmployeeRole.Support,
                languages: new List<Language>
                {
                    Language.Russian,
                    Language.English,
                    Language.French
                }
            ),
        };
        Console.WriteLine("Сотрудники, которые знают русский и английский язык:\n");
        foreach (Employee employee in employees)
        {
            if (employee.bilengual_and_have_email() != "")
            {
                Console.WriteLine(employee.bilengual_and_have_email());
            }
        }

        Console.WriteLine("\n\nОтчет о всех сотрудниках:\n");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.report());
        }
    }
}
