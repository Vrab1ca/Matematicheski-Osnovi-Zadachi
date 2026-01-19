namespace VeroiatnostZar
{
    internal class Veroiatnostzar
    {
        static void Main(string[] args)
        {
            int[] count = new int[7]; 
            Random rand = new Random();

            for (int i = 0; i < 100000; i++)
            {
                int roll = rand.Next(1, 7);
                count[roll]++;
            }

            Console.WriteLine("Резултати от 100000 хвърляния:");
            for (int i = 1; i <= 6; i++)
            {
                double prob = (count[i] / 100000.0) * 100;
                Console.WriteLine($"{i}: {count[i]} пъти ({prob:F2}%)");
            }
        }
    }
}
