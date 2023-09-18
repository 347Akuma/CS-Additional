namespace _0._Demo_Fiddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // how to read input until a specific command is received:

            // 1st-way:

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine(); //<- absolutely necessary, so the variable can change it's value
            }

            // 2nd-way:

            string text;
            while((text = Console.ReadLine()) != "Stop") // require input on each condition check itself, giving priority with ()
            {
                Console.WriteLine(text);
            }
        }
    }
}