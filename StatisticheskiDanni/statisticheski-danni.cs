namespace StatisticheskiDanni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа разделени с интервал:");
            string[] input = Console.ReadLine().Split(' ');
            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

        
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;

            int maxCount = 0;
            double moda = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    moda = numbers[i];
                }
            }

            Array.Sort(numbers);
            double median;
            if (numbers.Length % 2 == 0)
            {
                median = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2;
            }
            else
            {
                median = numbers[numbers.Length / 2];
            }

            Console.WriteLine($"Средно: {avg:F2}");
            Console.WriteLine($"Мода: {moda}");
            Console.WriteLine($"Медиана: {median}");
        }
    }
}
