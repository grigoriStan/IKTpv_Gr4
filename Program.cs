class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("number 1 - 3");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                a();
                break;

            case 2:
                b();
                break;

            case 3:
                c();
                break;

            default:
                Console.WriteLine("vale");
                break;
        }
    }
    static void a()
    {
        Console.Write("mis suurusega püramid");
        int size = int.Parse(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
    static void b()
    {
        Console.Write("mis suurusega rut");
        int side = int.Parse(Console.ReadLine());

        for (int i = 0; i < side; i++)
        {
            Console.WriteLine(new string('*', side));
        }

        int perimeter = 4 * side;
        int area = side * side;

        Console.WriteLine($"P: {perimeter}");
        Console.WriteLine($"S: {area}");
    }
    static void c()
    {
        Console.Write("mis laius");
        int width = int.Parse(Console.ReadLine());

        Console.Write("mis kõrgus");
        int height = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(new string('*', width));
        }

        int perimeter = 2 * (width + height);
        int area = width * height;

        Console.WriteLine($"P: {perimeter}");
        Console.WriteLine($"S: {area}");
    }
}
