namespace _10._OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += n1;
                }
                else
                {
                    sumOdd += n1;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                int diff = Math.Abs(sumOdd - sumEven);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
           }

        }
    }
}
//                int newNum = int.Parse(Console.ReadLine());

//                if (newNum.length % 2 == 0)
//                {
//                    sumEven+= newNum;
//                }
//                else
//                {
//                    sumOdd+= newNum;
//                }
//            }
//            if (sumEven == sumOdd)
//            {
//                Console.WriteLine("Yes");
//                Console.WriteLine($"Sum = {sumEven}");
//            }
//            else
//            {
//                int diff = sumEven - sumOdd;
//                Console.WriteLine("No");
//                Console.WriteLine($"Diff = {diff:F2}");
//            }
//        }
//    }
//}