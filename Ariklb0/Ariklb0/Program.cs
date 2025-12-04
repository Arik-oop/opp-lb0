using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariklb0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Количество яблок:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вес:");
            double V = Convert.ToDouble(Console.ReadLine());
            double I = C * V;
            Console.WriteLine($"Стоимость: {I} рублей");
        }
    }
}
