using System;

namespace входной_контроль
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Step(a, b);

            Console.WriteLine("Задача 3");
            Console.WriteLine("введите число: ");
            int с = Convert.ToInt32(Console.ReadLine());
            Ostat(с);

            Console.WriteLine("Задача 4");
            Console.WriteLine("введите число: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Chislo(p);

            Console.WriteLine("Задача 5");
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Resh(x, y);

            Console.WriteLine("Задача 6");
            Console.WriteLine("введите число: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Fib(l);

            Console.WriteLine("Задача 7");
            Console.WriteLine("введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Posled(n);

            Console.WriteLine("Задача 8");
            Console.WriteLine("введите первый результат: ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второй результат: ");
            double q2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите третий результат: ");
            double q3 = Convert.ToDouble(Console.ReadLine());
            Plav(q, q2, q3);

        }

        public static void Step(double a, double b)
        {
            Console.WriteLine("Результат: " + Math.Pow(a, b));
        }

        public static void Ostat(int a)
        {
            int b = a % 2;
            int c = a % 3;
            if (b == c)
            {
                Console.WriteLine("Введенное число " + a + " дает одинаковый остаток от деления на 2 и 3");
            }
            else
            {
                Console.WriteLine("Введенное число " + a + " НЕ дает одинаковый остаток от деления на 2 и 3");
            }
        }

        public static void Chislo(int n)
        {
            if(n<1&&n>10)
            {
                Console.WriteLine("рядом не может быть меньше 1 и больше 10!");
            }
            else
            {
                string mas = Convert.ToString(n);
                mas.Reverse();
                for (int i = mas.Length; i >0; i--)
                {
                    Console.WriteLine(mas[i-1]);
                }
            }
        }

        public static void Resh(double x, double y)
        {
            double otv = (1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4));
            Console.WriteLine("ответ: " + otv);
        }

        public static void Posled(int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += (i + 1) / (i + 2);
            }
            Console.WriteLine(sum);
        }

        public static void Plav(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("Результат победителя: " + a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("Результат победителя: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Результат победителя: " + c);
            }
            else if (a == b && a > c)
            {
                Console.WriteLine("Результаты 2 победителей: " + a);
            }
            else if (a == c && a > b)
            {
                Console.WriteLine("Результаты 2 победителей: " + a);
            }
            else if (b == c && b > a)
            {
                Console.WriteLine("Результаты 2 победителей: " + b);
            }
            else
            {
                Console.WriteLine("Все победители! Результат: " + a);
            }
        }

        public static void Fib(int n)
        {
            int[] mas = new int[n];
            mas[0] = 0;
            mas[1] = 1;
            for (int i = 2; i < n; i++)
            {
                mas[i] = mas[i - 1] + mas[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(mas[i] + " - " + i);
                }
            }
        }
    }

}
