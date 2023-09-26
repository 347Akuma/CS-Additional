namespace _03._Aluminium_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod(child1: "ThisIsTheLongestNameEver", child2: "Michellandjelo", child3: "ActuallyThisIsTheLongestNameEver");
        }




        static void MyMethod(string child1, string child2, string child3)
        {
            if (child1.Length > child2.Length && child1.Length > child3.Length)
            {
                Console.WriteLine($"First child has the longest name: {child1}");
            }
            else if (child2.Length > child1.Length && child2.Length > child3.Length)
            {
                Console.WriteLine($"Second child has the longest name: {child2}");
            }
            else
            {
                Console.WriteLine($"Third child has the longest name: {child3}");
            }

        }
    }
}