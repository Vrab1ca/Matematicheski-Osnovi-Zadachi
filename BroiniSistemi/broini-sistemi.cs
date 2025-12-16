namespace BroiniSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число, база от и база към (например: 10 10 2):");
            string[] input = Console.ReadLine().Split(' ');
            int number = int.Parse(input[0]);
            int fromBase = int.Parse(input[1]);
            int toBase = int.Parse(input[2]);

            
            int decimal10 = Convert.ToInt32(number.ToString(), fromBase);

          
            string result = Convert.ToString(decimal10, toBase);

            Console.WriteLine($"Резултат: {result}");
        }
    }
}
