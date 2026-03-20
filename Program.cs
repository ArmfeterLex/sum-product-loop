using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace con121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число (от 3 до 9) ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int pro = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i; pro *= i;
                Console.WriteLine("шаг = {0} сумма = {1} произведение = {2}", i, sum, pro);
            }
            Console.ReadKey();
        }
    }
}
