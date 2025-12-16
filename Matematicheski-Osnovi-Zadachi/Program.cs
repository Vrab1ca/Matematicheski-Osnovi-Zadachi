namespace Matematicheski_Osnovi_Zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете задача (1-8):");
            Console.WriteLine("1. Преобразуване на бройни системи");
            Console.WriteLine("2. Средно аритметично, мода и медиана");
            Console.WriteLine("3. Детерминанта на матрица 3x3");
            Console.WriteLine("4. Корени на квадратно уравнение");
            Console.WriteLine("5. Най-къс 3D вектор");
            Console.WriteLine("6. Операции с множества");
            Console.WriteLine("7. Пермутации, комбинации и вариации");
            Console.WriteLine("8. Вероятност при хвърляне на зар");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: BroiniSistemi(); break;
                case 2: StatisticheskiDanni(); break;
                case 3: DeterminantaMatrica(); break;
                case 4: KoreniPolinom(); break;
                case 5: NaiKusVektor(); break;
                case 6: OperaciiMnojestva(); break;
                case 7: KombinatorikaPKV(); break;
                case 8: VeroiatnostZar(); break;
            }
        }
    }