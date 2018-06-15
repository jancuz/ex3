using System;
using MyLibrary;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = AskData.ReadDoubleNumber("Введите координату x: ", double.MinValue, double.MaxValue);
            double y = AskData.ReadDoubleNumber("Введите координату у: ", double.MinValue, double.MaxValue);

            bool ans = (y <= 3 * x + 2 && y <= -3 * x + 2 && y >= -1);

            Console.WriteLine("Ответ: " + ans);

            Console.WriteLine("Нажмите Enter для завершения работы програмы");
            Console.ReadLine();
        }
    }
}
