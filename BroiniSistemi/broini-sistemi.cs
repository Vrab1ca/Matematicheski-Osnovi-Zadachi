namespace BroiniSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            string num = Console.ReadLine();

            Console.Wriote("От бройна система: ");
            int fromBase = int.Parse(Console.ReadLine());

            Console.Write("В бройна система: ");
            int toBase = int.Parse(Console.ReadLine());

            int decimalValue = ToDecimal(num, fromBase);
            string result = FromDecimal(decimalValue, toBase);

            Console.WriteLine("Резултат: {result}");

            static string FromDecimal(int num, int baseN)
            {
                int result = 0;
                foreach (char c in num)
                {
                    int digit;
                    if (c >= '0' && c <= '9')
                        digit = c - '0';
                    else if
                        digit = c - 'A' + 10;
                    else
                        digit = c - 'a' + 10;

                    result = result * baseN + digit;
                }
                return result;
            }

            static string FromDecimal(int num, int baseN)
            {
                if (num == 0) return "0";
                string result = "";

                while (num > 0)
                {
                    int digit = num % baseN;
                    result = (digit < 10 ? (char)(digit + '0') : (char)(digit - 10 + 'A')) + result;
                    num /= baseN;
                }
                return result;
            }
        }
    }
}
