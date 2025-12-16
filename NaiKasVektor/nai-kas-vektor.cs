using System.Text;

namespace NaiKasVektor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Въведете брой вектори:");
            int n = int.Parse(Console.ReadLine());

            double minLength = double.MaxValue;
            string minVector = "";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Въведете вектор {i + 1} (x y z):");
                string[] input = Console.ReadLine().Split(' ');
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                double z = double.Parse(input[2]);

                double length = Math.Sqrt(x * x + y * y + z * z);

                if (length < minLength)
                {
                    minLength = length;
                    minVector = $"({x}, {y}, {z})";
                }
            }

            Console.WriteLine($"Най-къс вектор: {minVector} с дължина {minLength:F2}");
        }

    }
}

