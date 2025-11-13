namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());

            

            string imput = Console.ReadLine();
            switch (imput)
            {
                case "+":
                    Console.WriteLine($"tulemus: {firstNumber + secondNumber}");
                        break;
                case "-":
                    Console.WriteLine($"tulemus: {firstNumber - secondNumber}");
                        break;
                case "*":
                    Console.WriteLine($"tulemus: {firstNumber * secondNumber}");
                        break;
                case "/":
                    Console.WriteLine($"tulemus: {firstNumber / secondNumber}");
                        break;




            }
        }
    }
}
