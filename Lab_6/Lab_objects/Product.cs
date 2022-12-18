namespace Lab_6;

public class Category
{
    public readonly int Id;
    public readonly string Name;

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Manufactory
{
    public readonly int Id;
    public readonly string Name;
    public readonly string Country;

    public Manufactory(int id, string name, string country)
    {
        Id = id;
        Name = name;
        Country = country;
    }
}

public class Product
{
    public readonly int Id;
    public readonly int CategoryId;
    public readonly int ManufacturyId;
    public readonly string Name;
    public readonly int Amount;
    public readonly int Price;

    public Product(int id, int categoryId, int manufacturyId, string name, int amount, int price)
    {
        Id = id;
        CategoryId = categoryId;
        ManufacturyId = manufacturyId;
        Name = name;
        Amount = amount;
        Price = price;
    }

    public static Product GenerateRandomProduct()
    {
        return new Product(
            id: Faker.RandomNumber.Next(1, 1000),
            categoryId: Faker.RandomNumber.Next(1, 5),
            manufacturyId: Faker.RandomNumber.Next(1, 10),
            //I'm too lazy to call manually, so we will sell People
            name: Faker.Name.First(),
            amount: Faker.RandomNumber.Next(0, 1),
            price: Faker.RandomNumber.Next(1, 100000)
        );
    }

    public override string ToString()
    {
        return $"ID: {Id}, Category ID: {CategoryId}, Manufactury ID: {ManufacturyId}, Name: {Name}, Amount: {Amount}, Price: {Price}";
    }
}
