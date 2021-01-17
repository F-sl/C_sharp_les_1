using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?"); // Спрашиваем имя пользователя и переводим консоль на новую строку
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}");
        }
    }
}
