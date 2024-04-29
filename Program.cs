using System.ComponentModel.Design;

namespace DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            Console.WriteLine("Введите сторорны прямоугольника");
            Console.WriteLine("Введите сторону A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B:");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите сторону квадрата:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < c || b < c)
            {
                Console.WriteLine("Такой квадрат разместить в прямоугольнике не возможно");
            }
                

            int count = (a / c) * (b / c);
            double area = a * b - count * c * c;
          
            Console.WriteLine("Количество квадратов: " + count);
            Console.WriteLine("Площадь незанятой части прямоугольника: " + area);

            Console.WriteLine("\n+++++++++++++++++++++++++++++\n");
            //Задача 2
            double initalDeposit = 10000;
            double targetDeposit = 11000;
            double interestRate;
            int months = 0;

            Console.WriteLine("Введите процентную ставку(0 < P < 25:)");

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out interestRate) && interestRate > 0 && interestRate < 25)
                { break; }
                else { Console.WriteLine("Недопустимое значение"); };
            }

            while (initalDeposit < targetDeposit)
            {
                initalDeposit += initalDeposit * (interestRate / 100);
                months++;
            }

            Console.WriteLine("Количество месяцев до нужной суммы: " + months);
            Console.WriteLine("Итоговый размер вклада: " + initalDeposit);

            Console.WriteLine("\n+++++++++++++++++++++++++++++\n");
            //Задача 3

            Console.WriteLine("Введите первое число диапазона:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число диапазона:");
            int e = int.Parse(Console.ReadLine());

            for(int i = d; i <= e; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n+++++++++++++++++++++++++++++\n");
            //Задача 4
            Console.WriteLine("Введите целое число больше 0");
            int n = int.Parse(Console.ReadLine());

            if(n<0) { Console.WriteLine("Число должно быть больше 0"); }

            int reverseNumber = 0;
            while(n > 0)
            {
                reverseNumber = reverseNumber*10 + n%10;
                n/= 10;
            }
            Console.WriteLine("Число наоборот:" +  reverseNumber);
        }
    }
}