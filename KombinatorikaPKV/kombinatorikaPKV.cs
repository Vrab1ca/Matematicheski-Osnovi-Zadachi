namespace KombinatorikaPKV
{
    internal class kombinatorikaPKV
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете n и k:");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);


            long nFact = 1;
            for (int i = 2; i <= n; i++)
            {
                nFact *= i;
            }

            long kFact = 1;
            for (int i = 2; i <= k; i++)
            {
                kFact *= i;
            }

            long nkFact = 1;
            for (int i = 2; i <= (n - k); i++)
            {
                nkFact *= i;
            }

            long perm = nFact;

            long comb = nFact / (kFact * nkFact);


            long var = nFact / nkFact;

            Console.WriteLine($"Пермутации: {perm}");
            Console.WriteLine($"Комбинации: {comb}");
            Console.WriteLine($"Вариации: {var}");
        }
    }
}
