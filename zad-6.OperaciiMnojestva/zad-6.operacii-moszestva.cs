namespace OperaciiMnojestva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първо множество (числа с интервал):");
            string[] input1 = Console.ReadLine().Split(' ');
            int[] set1 = new int[input1.Length];
            for (int i = 0; i < input1.Length; i++)
            {
                set1[i] = int.Parse(input1[i]);
            }

            Console.WriteLine("Въведете второ множество:");
            string[] input2 = Console.ReadLine().Split(' ');
            int[] set2 = new int[input2.Length];
            for (int i = 0; i < input2.Length; i++)
            {
                set2[i] = int.Parse(input2[i]);
            }

           
            Console.Write("Сечение: ");
            for (int i = 0; i < set1.Length; i++)
            {
                for (int j = 0; j < set2.Length; j++)
                {
                    if (set1[i] == set2[j])
                    {
                        Console.Write(set1[i] + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();

     
            Console.Write("Обединение: ");
            for (int i = 0; i < set1.Length; i++)
            {
                Console.Write(set1[i] + " ");
            }
            for (int i = 0; i < set2.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < set1.Length; j++)
                {
                    if (set2[i] == set1[j])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    Console.Write(set2[i] + " ");
                }
            }
            Console.WriteLine();

     
            Console.Write("Разлика: ");
            for (int i = 0; i < set1.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < set2.Length; j++)
                {
                    if (set1[i] == set2[j])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    Console.Write(set1[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
