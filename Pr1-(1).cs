//Написать программу, которая реализует диалог с пользователем: Запрашивает с клавиатуры два целых числа и выводит их сумму.

using System;

namespace Total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.Write("a= "); 
            a = Console.ReadLine();
            Console.Write("b= ");
            b = Console.ReadLine();
            Console.WriteLine(a + "+" + b + "=" + (Convert.ToInt32(a) + Convert.ToInt32(b)));

        }
    }
}
