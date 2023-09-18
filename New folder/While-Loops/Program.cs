namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            while ((text = Console.ReadLine()) != "Stop") // require input on each condition check itself, giving priority with ()
            {
                Console.WriteLine(text);
            }
        }
        }
    }