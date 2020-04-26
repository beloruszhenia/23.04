using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*создайте пожалуйста новый класс в котором есть два свойства "Min" и "Max" 
 * (целое число) и метод который получает среднее значение из Min и Max
 * (результат должен определиться по формуле (Min + Max)/2 )*/

namespace Console24_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Minmax p = new Minmax();

            p.Min = 16;
            p.Max = 66;

            Console.WriteLine("Min = {0}    Max={1}", p.Min, p.Max);
            Console.WriteLine($"Srednee znachenie = {p.Srednee()}");
            Console.ReadKey();
        }
    }
}
