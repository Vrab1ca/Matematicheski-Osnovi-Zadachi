namespace DeterminantaMatrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете матрица 3x3 (9 числа разделени с интервал):");
            string[] input = Console.ReadLine().Split(' ');
            double[,] matrix = new double[3, 3];

            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = double.Parse(input[index++]);
                }
            }

            
            double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                       - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                       + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            Console.WriteLine($"Детерминанта: {det}");
        }
    }
}
