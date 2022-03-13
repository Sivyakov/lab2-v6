using System;

namespace lab2_v6
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm firm = new Firm();
            Console.Write("Введите название фирмы: ");
            firm.Name = Console.ReadLine();
            Console.Write("Страховка: ");
            firm.Insurance = Console.ReadLine();
            Console.Write("Время существования фирмы: ");
            firm.Age = int.Parse(Console.ReadLine());
            Console.Write("Заработная плата: ");
            firm.Salary = int.Parse(Console.ReadLine());
            Console.Write("Рейтинг: ");
            firm.Rating = int.Parse(Console.ReadLine());
            firm.PrintFilm();
        }
    }
}
