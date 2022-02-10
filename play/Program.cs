using System;

namespace play
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра Угадай число");
            Console.Write("Чтобы начать, нажмите enter");
            Console.ReadLine();
            Console.Write("Введите начало интервала(целое): ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите конец интервала(целый): ");
                int y = int.Parse(Console.ReadLine());

                Random rand = new Random();

                int A = rand.Next(x, y);
                int l = 0;
                while (true)
                {
                    Console.Write("Введите число:");

                    int B = int.Parse(Console.ReadLine());

                    l++;
                    if (B == A)
                    {
                        Console.WriteLine("!Вы угадали c {0} попытки!", l);

                        break;
                    }

                    else if (B > A)
                    {
                        Console.WriteLine("Ваше число больше");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число меньше");
                    }

                }
                     Console.Write("Нажмите enter, чтобы выйти из игры");
                     Console.ReadLine();
        }
    }
}
