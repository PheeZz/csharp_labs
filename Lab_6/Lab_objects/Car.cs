namespace Lab_6;
using random = System.Random;

public enum Producer
{
    Mercedes,
    Audi,
    Volkswagen,
    Ford,
    Toyota,
    Honda,
    Hyundai,
    Kia,
    Mazda,
    Nissan,
    Mitsubishi,
    Subaru,
    Suzuki,
    Tesla,
    Chevrolet,
    Dodge,
    Jeep,
    Cadillac,
    Lincoln,
    Chrysler,
    Fiat,
    Alfa_Romeo,
    Lancia,
    Acura,
    Infiniti,
    Lexus,
    Scion,
    Smart,
    Volvo,
    Saab,
    Mini,
    Rolls_Royce,
    Bentley,
    Bugatti,
    Lamborghini,
    Maserati,
    Ferrari,
    Porsche,
    Peugeot,
    Citroen,
    Renault,
    Opel,
    Seat,
    Skoda,
    Dacia,
    Lada,
    Daewoo,
    Geely,
    Great_Wall,
    Chery,
    BYD,
    JAC,
    Haval,
    Changan,
    Changhe,
    Zotye,
    Haima,
    Lifan,
    FAW,
    Dongfeng,
}

public enum Model
{
    A1,
    A2,
    A3,
    A4,
    A5,
    A6,
    A7,
    A8,
    Q2,
    Q3,
    Q5,
    Q7,
    Q8,
    R8,
    RS3,
    RS4,
    RS5,
    RS6,
    RS7,
    RSQ3,
    S3,
    S4,
    S5,
    S6,
    S7,
    S8,
    SQ5,
    SQ7,
    SQ8,
    TT,
    TTS,
    TTRS,
    A,
    B,
    C,
    E,
    G,
    GLA,
    GLB,
    GLC,
    GLE,
    GLS,
    S,
    CLA,
    CLS,
    SL,
    SLK,
    SLC,
    SLR,
    SLS,
    AMG_GT,
    AMG_GT_4,
    AMG_GT_C,
    AMG_GT_R,
    AMG_GT_S,
    AMG_GT_R_Pro,
    AMG_GT_4_Door_Coupe,
    AMG_GT_4_Door_Coupe_Pro,
    AMG_GT_63,
    AMG_GT_63_S,
    AMG_GT_63_S_4Matic,
    AMG_GT_63_S_4Matic_Plus,
    AMG_GT_63_S_4Matic_Plus_Edition_1,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_1,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_2,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_3,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_4,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_5,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_6,
    AMG_GT_63_S_4Matic_Plus_Edition_1_Pro_7,
}

public enum Color
{
    Black,
    White,
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Purple,
    Brown,
    Grey,
    Silver,
    Gold,
    Pink,
    Beige,
    Turquoise,
    Violet,
    Magenta,
    Crimson,
    Olive,
    Teal,
    Navy,
    Maroon,
    Aqua,
    Lime,
    Cyan,
    Indigo,
    Peach,
    Lavender,
    Mauve,
    Taupe,
    Azure,
    Amber,
    Sienna,
    Charcoal,
    Lilac,
    Mustard,
    Salmon,
    Coral,
    Khaki,
    Ivory,
    Tan,
    Mint,
    Apricot,
    Plum,
    Chestnut,
    Coffee,
    Eggplant,
    Fuchsia,
    Ginger,
    Wine,
    Burgundy,
    Gray,
}

public class Car
{
    public Producer Producer { get; set; }
    public Model Model { get; set; }
    public Color Color { get; set; }
    public string RegistrationNumber { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }

    public Car(
        Producer producer,
        Model model,
        Color color,
        string? registrationNumber,
        decimal price,
        int year
    )
    {
        Producer = producer;
        Model = model;
        Color = color;
        RegistrationNumber = registrationNumber;
        Price = price;
        Year = year;
    }

    public static Car GenerateRandomCar()
    {
        var random = new Random();
        var producer = (Producer)random.Next(0, Enum.GetNames(typeof(Producer)).Length);
        var model = (Model)random.Next(0, Enum.GetNames(typeof(Model)).Length);
        var color = (Color)random.Next(0, Enum.GetNames(typeof(Color)).Length);
        var registrationNumber =
            $"{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}";
        var price = random.Next(1000, 100000);
        var year = random.Next(2000, 2022);

        return new Car(producer, model, color, registrationNumber, price, year);
    }

    public override string ToString()
    {
        return $"Producer: {Producer}, Model: {Model}, Color: {Color}, RegistrationNumber: {RegistrationNumber}, Price: {Price}, Year: {Year}";
    }
}
