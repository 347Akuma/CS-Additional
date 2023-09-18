namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int yearlyGrade = 1;
            int repeats = 0;
            bool isExcluded = false; // flag
            double marksSum = 0;

            while (yearlyGrade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    repeats++;
                    if (repeats > 1)
                    {
                        isExcluded = true;
                        break;
                    }
                    continue;
                }
                marksSum += currentGrade;
                yearlyGrade++;
            }
            if (isExcluded)
            {
                Console.Write($"{studentName} has been excluded at {yearlyGrade} grade");
            }
            else
            {
                double average = marksSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {average:f2}");
            }


        }
    }
}