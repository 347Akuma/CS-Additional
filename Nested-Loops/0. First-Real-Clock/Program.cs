namespace _0._First_Real_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // Hide the cursor

            while (true)
            {
                Console.SetCursorPosition(0, 0); // Move cursor to the beginning of the console

                for (int h = 0; h <= 23; h++)
                {
                    for (int m = 0; m <= 59; m++)
                    {
                        for (int s = 0; s <= 59; s++)
                        {
                            Console.Write($"{h:D2}:{m:D2}:{s:D2}");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(0, 0); // Move cursor back to the beginning
                        }
                    }
                }
            }
        }
    }
}

