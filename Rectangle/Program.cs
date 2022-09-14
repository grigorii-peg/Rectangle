using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            var x = Console.ReadLine();
            Console.Write("Введите высоту прямоугольника: ");
            var y = Console.ReadLine();
            if (int.TryParse(x, out var x_out) && int.TryParse(y, out var y_out))
            {
                var x_con = (Console.WindowWidth - x_out) / 2;
                var y_con = (Console.WindowHeight - y_out) / 2;
                for (int j = 0; j < y_out; j++)
                {
                    for (int i = 0; i < x_out; i++)
                    {
                        Console.SetCursorPosition(x_con++, y_con);
                        Console.Write("░");
                    }
                    x_con = (Console.WindowWidth - x_out) / 2;
                    Console.SetCursorPosition(x_con, y_con++);
                }
            }
            Console.ReadKey();
        }
    }
}
