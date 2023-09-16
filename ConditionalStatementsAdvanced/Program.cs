namespace ConditionalStatementsAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTimeMin = examHour * 60 + examMinutes; // we transform the exam hour in minutes
            int arrivalTimeMin = arrivalHour * 60 + arrivalMinutes; // same with arrival

            if (arrivalTimeMin > examTimeMin) // we compare the totals in minutes, if we arrived later -> print Late
            {
                Console.WriteLine("Late");
                if (arrivalTimeMin - examTimeMin < 60) // late less than an hour -> print minutes late
                {
                    Console.WriteLine($"{arrivalTimeMin - examTimeMin} minutes after the start");
                }
                else // if more than an hour, print the hours + minutes late
                {
                    int hours = (arrivalTimeMin - examTimeMin) / 60; // we get the hour late by dividing it by 60 minutes. we don't need the remainder -> prioritize actions!
                    int minutes = (arrivalTimeMin - examTimeMin) % 60; // here, we need the remainder hence we use modular division

                    //if (minutes < 10) // the long version of formatting minutes if they're less than 10, i.e 09, 08, 07... is with an if-else check and interpolated string with an additional "0"
                    //{
                    //    Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"{hours}:{minutes} hours before the start");
                    //}

                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start"); // short version is using the "D2" operator - it will explicitly format single-digit numbers to two digit ones, such as 5 = 05
                }
            }
            else if (arrivalTimeMin == examTimeMin || examTimeMin - arrivalTimeMin <= 30) // with this logic, we guarantee that we're either exactly on time or 30 minutes early
            {
                Console.WriteLine("On time"); // if the difference is 0 we directly print on time
                if (examTimeMin - arrivalTimeMin != 0) // with this logic we guarantee that if the difference between the exam time and our arrival is not 0, we're some minutes early -> print how many
                {
                    int minutes = examTimeMin - arrivalTimeMin;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (examTimeMin - arrivalTimeMin > 30)
            {
                Console.WriteLine("Early");
                if (examTimeMin - arrivalTimeMin < 60) // we're early with less than an hour, aka minutes
                {
                    int minutes = examTimeMin - arrivalTimeMin;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    int hours = (examTimeMin - arrivalTimeMin) / 60; // important to prioritize actions
                    int minutes = (examTimeMin - arrivalTimeMin) % 60;

                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
        }
    }
}