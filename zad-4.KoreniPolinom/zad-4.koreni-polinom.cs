namespace KoreniPolinom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете коефициенти (например: 3 2 -16 за 3x^2 + 2x - 16):");
            string[] input = Console.ReadLine().Split(' ');
            double[] coef = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                coef[i] = double.Parse(input[i]);
            }

            if (coef.Length == 3)
            {
                double a = coef[0];
                double b = coef[1];
                double c = coef[2];

                double d = b * b - 4 * a * c;

                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Корени: {x1:F2} и {x2:F2}");
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Един корен: {x:F2}");
                }
                else
                {
                    Console.WriteLine("Няма реални корени");
                }
            }
            else
            {
                Console.WriteLine("Работи само за квадратни уравнения (3 коефициента)");
            }
        }
    }

}

