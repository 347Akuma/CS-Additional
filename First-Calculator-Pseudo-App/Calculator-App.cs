namespace _00._Simple_Calculator_Pseudo_Infinite_Loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("1. Please enter  '+', '-', '*', '/', or '%' to get started. ");
            Console.WriteLine("2. Choose and enter your first number.");
            Console.WriteLine("3. Choose and enter your second number.");
            Console.WriteLine("4. Voila! Have fun with the App :)");
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "+")
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Addition:");
                    Console.WriteLine($"{a} + {b} = {Math.Abs(a + b)}");
                }
                else if (command == "-")
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Subtraction:");
                    Console.WriteLine($"{a} - {b} = {Math.Abs(a - b)}");
                }
                else if (command == "*")
                {
                    int a = int.Parse(Console.ReadLine()) ;
                    int b = int.Parse(Console.ReadLine() );

                    Console.WriteLine("Multiplication:");
                    Console.WriteLine($"{a} * {b} = {Math.Abs(a * b)}");
                }
                else if (command == "/")
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Division:");
                    Console.WriteLine($"{a} / {b} = {Math.Abs(a / b)}");
                }
                else if (command == "%")
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Modular Division:");
                    Console.WriteLine($"{a} % {b} = {Math.Abs(a % b):f2}");
                }
                else if (command == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Quit calculator? (yes/no)");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        break;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Please enter '+', '-', '*', '/', or '%' to continue using the app: ");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}