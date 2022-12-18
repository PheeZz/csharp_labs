namespace Lab_6;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var persons = GenerateRandomPersons(count: 100);
        var cars = GenerateRandomCars(count: 100);
        var products = GenerateRandomProducts(count: 100);

        #region [persons]: born after 2000
        persons
            .ApplyFilter(startDate: new DateTime(2000, 1, 1), endDate: new DateTime(2000, 12, 31))
            .Print("Persons born after 2000");

        #endregion

        #region [persons]: born after 2000 and speaks English
        persons
            .ApplyFilter(
                startDate: new DateTime(2000, 1, 1),
                endDate: new DateTime(2000, 12, 31),
                languages: new List<Language> { Language.English }
            )
            .Print("Persons born after 2000 and speaks English");

        #endregion


        #region [cars]: NEW (year > 2019)
        cars.Where(car => car.Year > 2019).Print("Cars NEW");
        // show count of the cars
        // not optimal way BRUH, but it works
        Console.WriteLine($"Count of the cars: {cars.Count(car => car.Year > 2019)}");
        #endregion

        #region [cars]: NORMAL (2015 <=  year < 2019)
        cars.Where(car => car.Year >= 2015 && car.Year < 2019).Print("Cars NORMAL");
        Console.WriteLine(
            $"Count of the cars: {cars.Count(car => car.Year >= 2015 && car.Year < 2019)}"
        );
        #endregion

        #region [cars]: OLD (2010 <= year < 2015)
        cars.Where(car => car.Year >= 2010 && car.Year < 2015).Print("Cars OLD");
        Console.WriteLine(
            $"Count of the cars: {cars.Count(car => car.Year >= 2010 && car.Year < 2015)}"
        );
        #endregion

        #region [cars]: VERY OLD (year < 2010)
        cars.Where(car => car.Year < 2010).Print("Cars VERY OLD");
        Console.WriteLine($"Count of the cars: {cars.Count(car => car.Year < 2010)}");
        #endregion

        #region [products]: categoryId = 2
        products.Where(product => product.CategoryId == 2).Print("Products with categoryId = 2");
        Console.WriteLine(
            $"Count of the products: {products.Count(product => product.CategoryId == 2)}"
        );
        #endregion

        #region [products]: manufacturyId = 3
        products
            .Where(product => product.ManufacturyId == 3)
            .Print("Products with manufacturyId = 3");
        Console.WriteLine(
            $"Count of the products: {products.Count(product => product.ManufacturyId == 3)}"
        );
        #endregion

        #region [products]: price < 10000
        products.Where(product => product.Price < 10000).Print("Products with price < 10000");
        Console.WriteLine(
            $"Count of the products: {products.Count(product => product.Price < 10000)}"
        );
        #endregion

        #region [products]: amount > 0
        products.Where(product => product.Amount > 0).Print("Products with amount > 0");
        Console.WriteLine(
            $"Count of the products: {products.Count(product => product.Amount > 0)}"
        );
        #endregion

        #region [products]: average price at all
        Console.WriteLine("------------------------");
        Console.WriteLine($"Average price at all: {products.Average(product => product.Price)}");
        Console.WriteLine("------------------------");
        #endregion

        #region [products]: average price by category
        Console.WriteLine("------------------------");
        Console.WriteLine("Average price by category:");
        products
            .GroupBy(product => product.CategoryId)
            .Select(
                group =>
                    new
                    {
                        CategoryId = group.Key,
                        AveragePrice = group.Average(product => product.Price)
                    }
            )
            .ToList()
            .ForEach(
                group =>
                    Console.WriteLine(
                        $"CategoryId: {group.CategoryId}, AveragePrice: {group.AveragePrice:0.00}"
                    )
            );
        Console.WriteLine("------------------------");
        #endregion

        #region [products]: average price by manufactury
        Console.WriteLine("------------------------");
        Console.WriteLine("Average price by manufactury:");
        products
            .GroupBy(product => product.ManufacturyId)
            .Select(
                group =>
                    new
                    {
                        ManufacturyId = group.Key,
                        AveragePrice = group.Average(product => product.Price)
                    }
            )
            .ToList()
            .ForEach(
                group =>
                    Console.WriteLine(
                        $"ManufacturyId: {group.ManufacturyId}, AveragePrice: {group.AveragePrice:0.00}"
                    )
            );
        Console.WriteLine("------------------------");
        #endregion

        #region [products]: average price by category and manufactury
        Console.WriteLine("------------------------");
        Console.WriteLine("Average price by category and manufactury:");
        products
            .GroupBy(product => new { product.CategoryId, product.ManufacturyId })
            .Select(
                group =>
                    new
                    {
                        CategoryId = group.Key.CategoryId,
                        ManufacturyId = group.Key.ManufacturyId,
                        AveragePrice = group.Average(product => product.Price)
                    }
            )
            .ToList()
            .ForEach(
                group =>
                    Console.WriteLine(
                        $"CategoryId: {group.CategoryId}, ManufacturyId: {group.ManufacturyId}, AveragePrice: {group.AveragePrice:0.00}"
                    )
            );
        Console.WriteLine("------------------------");
        #endregion
    }

    #region Lab_Objects

    public static List<Car> GenerateRandomCars(int count = 100)
    {
        //generate <count> random cars by using Car.GenerateRandomCar() method
        // and insert them into the list
        var cars = new List<Car>();
        for (int i = 0; i < count; i++)
        {
            cars.Add(Car.GenerateRandomCar());
        }
        return cars;
    }

    public static List<Person> GenerateRandomPersons(int count = 100)
    {
        // generate <count> random persons by using Person.GenerateRandomPerson() method
        // and insert them into the list
        var persons = new List<Person>();
        for (int i = 0; i < count; i++)
        {
            persons.Add(Person.GenerateRandomPerson());
        }
        return persons;
    }

    public static List<Product> GenerateRandomProducts(int count = 100)
    {
        // generate <count> random Pruducts by using Product.GenerateRandomProduct() method
        // and insert them into the list
        var products = new List<Product>();
        for (int i = 0; i < count; i++)
        {
            products.Add(Product.GenerateRandomProduct());
        }
        return products;
    }

    //[DEBUG] print all cars from the list
    public static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    #endregion
}
