using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Zavdan_5_6()
        {
            /*
             * Напечатать числа следующим образом:
                а) 21 20.4
                22 21.4
                ...
                35 34.4

                б) 16 15.5 16.8
                17 16.5 17.8
                ...
                24 23.5 24.8
             */
            //A
            for (int i = 21; i <= 35; i++)
                Console.WriteLine(i + " " + (i - 1) + ".2 ");
            //b
            for (int i = 16; i <= 24; i++)
                Console.WriteLine(i + " " + (i - 1) + ".5 " + i + ".8");
        }

        static void Zavdan_5_30()
        {
            /*
             *Найти:
                а) сумму кубов всех целых чисел от 20 до 40;
                б) сумму квадратов всех целых чисел от a до 50 (значение a вводится
                с клавиатуры; 0 <= a <= 50);
                в) сумму квадратов всех целых чисел от 1 до n (значение n вводится
                с клавиатуры; 1 <= n <= 100);
                г) сумму квадратов всех целых чисел от a до b (значения a и b вводятся с кла-
                виатуры; b >= a).
             */

            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //a

            int cube = 0;
            for (int i = 20; i <= 40; i++)
                cube += i * i * i;
            Console.WriteLine("а) Сумма кубов от 20 до 40: " + cube);

            //б

            int kvad = 0;
            for (int i = a; i <= 50; i++)
                kvad += i * i;
            Console.WriteLine("б) Сумма квадратов от " + a + " до 50: " + kvad);

            //в

            int sq = 0;
            for (int i = 1; i <= n; i++)
                sq += i * i;
            Console.WriteLine("в) Сумма квадратов от 1 до " + n + ": " + sq);

            //г

            int sq2 = 0;
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                    sq2 += i * i;
                Console.WriteLine("г) Сумма квадратов от " + a + " до " + b + ": " + sq2);
            }
            else
            {
                Console.WriteLine("г) Error число a > b ");
            }






        }

        static void Zavdan_5_54()
        {
            /*
             * Известны оценки по алгебре каждого ученика класса. Определить среднюю оценку.
             */

            const int N = 10;
            string a;
            float s = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}-ша оцінка: ", i + 1);
                a = Console.ReadLine();
                s = s + Convert.ToInt32(a);
            }
            s = s / N;
            Console.WriteLine("Середня оцінка: {0}", s);
            Console.ReadKey();
        }

        static void Zavdan_5_78()
        {
            /*
             Вычислить приближенно площадь одной арки синусоиды.
             */

            double x1 = 0;
            double x2 = Math.PI;

            int n = 1000; // количество разбиений 

            double step = (x2 - x1) / n;
            double s = 0;
            for (int i = 1; i < n - 1; i++)
            {
                double x = x1 + step * i;
                s += Math.Sin(x);
            }
            double sTotal = step * ((Math.Sin(x1) + Math.Sin(x2)) / 2 + s);
            Console.WriteLine(sTotal);
            Console.ReadKey();
        }

        static void Zavdan_6_2()
        {
            /*
                Дана непустая последовательность неотрицательных целых чисел, оканчи-
                вающаяся отрицательным числом. Найти среднее арифметическое всех чисел
                последовательности (без учета отрицательного числа).
             */

            int n = 0, s = 0, a;
            do
            {
                Console.Write("Введите целое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                s += a;
                n++;
            } while (a >= 0);
            double d = s - a;
            n--;
            d = d / n;
            Console.WriteLine("Среднее арифметическое = {0}", d);


        }

        static void Zavdan_6_26()
        {
            /*
             * Дано натуральное число.
                а) Определить его максимальную цифру.
                б) Определить его минимальную цифру.
             */

            int n = 10, min = 9, max = 0, d;
            Console.Write("Введите натуральное число: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                d = n % 10;
                if (d < min)
                    min = d;
                if (d > max)
                    max = d;
                n = n / 10;
            }
            Console.WriteLine($"Минимальная цифра - {min}, максимальная цифра - {max}");
            Console.ReadKey();


        }

        static void Zavdan_6_50()
        {
            /*
             * Дано натуральное число.
                а) Определить, есть ли в нем цифра a.
                б) Верно ли, что в нем нет цифры b?
                в) Верно ли, что цифра a встречается в нем более k раз?
                г) Определить, есть ли в нем цифры a и b.
             */
            int n = 10, a, b;
            Console.Write("Введите натуральное число n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите натуральное число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите натуральное число b: ");
            b = Convert.ToInt32(Console.ReadLine());

            //a

            int na = 0, d;
            while (n > 0)
            {
                d = n % 10;
                if (d == a)
                {
                    na++;
                    Console.WriteLine("а)Число " + a + " есть в " + n);
                    break;
                }
                else
                {
                    Console.WriteLine("а)Числа " + a + " нету в " + n);
                    break;
                }
            }


            //б

            int nb = 0, f;
            while (n > 0)
            {
                f = n % 10;
                if (f == a)
                {
                    nb++;
                    Console.WriteLine("б)Неверно число " + b + " есть в " + n);
                    break;
                }
                else
                {
                    nb++;
                    Console.WriteLine("б)Верно числа " + b + " нету в " + n);
                    break;
                }

            }


            //в

            int count = 0;
            while (n != 0)
            {

                if (n % 10 == b)
                    count++;
                n /= 10;
            }
            Console.WriteLine("в)Число {0} встречается: {1}", b, count);


            //г

            int r;
            while (n > 0)
            {
                r = n % 10;
                if (r == a && r == b)
                {
                    count++;
                    Console.WriteLine("г)Числа " + a + " и " + b + " есть в " + n);
                    break;
                }
                else if (r == a || r == b)
                {
                    count++;
                    Console.WriteLine("г)Есть только 1 число в " + n);
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("г)Здесь нет цифр " + a + " и " + b + " в " + n);
                    break;
                }
            }

        }

        static void Zavdan_6_74()
        {
            /*
             * Определить:
                    а) является ли заданное число степенью числа 3;
                    б) является ли заданное число степенью числа 5.
             */


            //a
            Console.Write("Введіть число: ");
            int N = int.Parse(Console.ReadLine());
            bool result = false;
            int K = 1;

            int J = N;
            if (N >= 3)
                while (N >= J)
                {

                    if (N == Math.Pow(3, K))
                    {
                        result = true;
                        break;
                    }
                }
            Console.WriteLine("K = {0} ");
            Console.WriteLine(result);
            Console.ReadLine();

            int L = 1;

            int P = N;
            if (N >= 5)
                while (N >= J)
                {

                    if (N == Math.Pow(5, L))
                    {
                        result = true;
                        break;
                    }
                }
            Console.WriteLine("L = {0} ");
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static void Zavdan_6_98()
        {

            /*
             * Начав тренировки, лыжник в первый день пробежал 10 км. 
             * Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. 
             * Определить в какой день он пробежит .больше 20 км.
             */

            double curValue = 10.0;
            const double targetValue = 20.0;
            int dayCnt = 1;
            while (curValue < targetValue)
            {
                dayCnt++;
                curValue *= 1.1;
            }
            Console.WriteLine($"На {dayCnt} день лыжник пробежит {curValue} км., что больше, чем 20 км.\nНажмите Enter для завершения работы программы.");
            Console.ReadLine();
        }

        static void Zavdan_7_7()
        {

            /*
             * Определить количество натуральных чисел из интервала от 100 до 500, сумма
                цифр которых равна 15.
             */

            int n = 0;
            int e, d, c;
            for (int k = 100; k < 501; k++)
            {
                c = k / 100;
                d = (k - c * 100) / 10;
                e = (k - c * 100) % 10;
                if ((c + d + e) == 15) ;
                n++;
            }
            Console.WriteLine(n);
        }

        static void Zavdan_7_31()
        {

            /*
             * Для каждой команды-участницы чемпионата по футболу известно ее количе-
                ство выигрышей и количество проигрышей. Определить, сколько команд
                имеют больше выигрышей, чем проигрышей.
             */

            Console.WriteLine("Введите количество игр: ");
            int n, not = 0, w = 0, f = 0, t = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество очков полученных за " + (i + 1) + " игру: ");
                t = Convert.ToInt32(Console.ReadLine());
                if (t == 0) f++;
                if (t == 3) w++;
                if (t == 1) not++;
            }
            Console.WriteLine("Количество ничьих: " + not);
            Console.WriteLine("Количество побед: " + w);
            Console.WriteLine("Количество поражений: " + f);
        }

        static void Zavdan_7_55()
        {
            /*
             * В компьютер по очереди поступают результаты спортсменов-участников со-
                ревнований по лыжным гонкам, уже пришедших к финишу (время, затрачен-
                ное на прохождение дистанции гонки). Выводить на экран лучший результат
                после ввода результата очередного спортсмена.
             */

            Console.Write("Введите количество спортсменов: ");
            byte quantity = byte.Parse(Console.ReadLine());
            int cur, min = int.MaxValue;
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("За сколько секунд пришел спортсмен №{0}: ", i + 1);
                cur = int.Parse(Console.ReadLine());
                if (cur < min) min = cur;
                Console.WriteLine("Лучший результат: {0} сек.", min);
            }
            Console.ReadKey();

        }


        static void Zavdan_7_79()
        {

            /*
             * Дана последовательность из m единиц и нулей. Рассмотреть отрезки этой по-
                следовательности (подпоследовательности идущих подряд чисел), состоящие
                из одних нулей. Получить наименьшую из длин рассматриваемых отрезков.
             */

            int[] a = new[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 };

            Console.Write("Массив: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }

            int i = 1;
            int mn = a.Length;

            while (i < a.Length)
            {
                if (a[i] == a[i - 1])
                {
                    int j = i;
                    int k = 1;

                    while (j < a.Length && a[j] == a[j - 1])
                    {
                        j++;
                        k++;
                    }

                    if (k < mn && k >= 2)
                    {
                        mn = k;
                    }

                    i += k;
                }
                else
                {
                    i++;
                }
            }

            if (mn == a.Length)
            {
                Console.WriteLine("Нет одинаковых рядом!");
            }
            else
            {
                Console.WriteLine("Наименьшая длина отрезка из нулей: " + mn);
            }

            Console.ReadKey();
        }


        static void Zavdan_7_103()
        {

            /*
             * Даны целые числа
                1 2 10 a a a , , ..., .
                Выяснить, верно ли, что количество положительных чисел не превышает 5.
             */

            int i = 0;
            Double sum = 0; //сумма
            while (i < 12)
            {
                Console.Write("Число : ");
                Double a = Convert.ToDouble(Console.ReadLine());
                if (a <= 10.75)
                {

                }
                else
                {
                    sum += a;
                }
                i++;
            }
            Console.WriteLine("сумма = {sum}");
            Console.ReadKey();
        }


        static void Zavdan_7_127()
        {

            /*
             * Дано натуральное число. Выяснить, является ли оно простым (простым на-
                зывается натуральное число, большее 1, не имеющее других делителей, кро-
                ме единицы и самого себя). Оператор цикла с условием не использовать
             */

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            while (counter < number / 2 + 1)
            {
                if (number % counter == 0)
                {
                    Console.Write("Число не простое");
                    Console.Read();
                    return;
                }
                counter++;
            }
            Console.Write("Число простое");
            Console.Read();
        }


        static void Zavdan_8_6()
        {
            /*
             * Напечатать полную таблицу сложения в виде:
                1 + 1 = 2 2 + 1 = 3 … 9 + 1 = 10
                1 + 2 = 3 2 + 2 = 4 … 9 + 2 = 11
                … … … …
                1 + 9 = 10 2 + 9 = 11 … 9 + 9 = 18
             */


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                    Console.Write($"{j} + {i} = {i + j}\t");
                Console.WriteLine();
            }
        }


        static int GetSimpleNum(int n)
        {
            // 8_32

            /*
             * Найти 100 первых простых чисел.
             */

            int count = 0;

            for (int i = 2; ; ++i)
            {
                if (IsSimple(i))
                    count++;
                if (count == 100)
                    return i;
            }
        }


        static void Zavdan_8_56()
        {
            /*
             * 8.56.*Даны целые числа n и m. Получить все натуральные числа, меньшие n и вза-
                имно простые с p.
             */
            int b, a;
            while (b != 0)
                b = a % (a = b);
            return a;


        }
    

    }


}








