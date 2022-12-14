namespace Lab_4;

static class Program
{
    public static void Main(string[] args)
    {
        // clear console before start
        Console.Clear();

        int[] input = { 10, -5, 6, 100, 0, -500, 100000 };
        var output = input.sorted(item => item > 100);

        var stream = new Stream(10);
        void first_viewer(int i, string message) =>
            Console.WriteLine($"{i}й зритель использует {message}");
        stream.on_new_message += first_viewer;
        Thread.Sleep(1500);

        stream.on_new_message -= first_viewer;
        Console.WriteLine("Зритель вышел с трансляции");

        void second_viewer(int i, string message) =>
            Console.WriteLine($"{i}й зритель использует {message}");
        stream.on_new_message += second_viewer;
        Thread.Sleep(1500);
    }
}
