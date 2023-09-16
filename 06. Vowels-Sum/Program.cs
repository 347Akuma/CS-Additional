namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value = 0;


            for (int i = 0; i < input.Length; i++)    //
            {
                char letter = input[i];

                if (letter == 'a')
                {
                    value += 1;
                }
                else if (letter == 'e')
                {
                    value += 2;
                }
                else if (letter == 'i')
                {
                    value += 3;
                }
                else if (letter == 'o')
                {
                    value += 4;
                }
                else if (letter == 'u')
                {
                    value += 5;
                }
            }
            Console.WriteLine(value);
        }
    }
}