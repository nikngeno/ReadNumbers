namespace ReadNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Read 10 numbers from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            // Calculate minimum, maximum, and average
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            foreach (int number in numbers)
            {
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }

            double average = (double)sum / numbers.Count;

            // Display results
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Average: " + average);
        }
    }
}
