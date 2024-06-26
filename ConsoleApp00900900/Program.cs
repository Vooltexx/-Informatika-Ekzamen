using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp00900900
{
    class Program
    {
        static void Main(string[] args)
        {
            //            9.Вычисление периметра квадрата
            //            Console.WriteLine("Введите сторону квадрата:");
            //            double a = Convert.ToDouble(Console.ReadLine());
            //            double P = 4 * a;
            //            Console.WriteLine($"Периметр квадрата: {P}");
            //            10.Вычисление периметра прямоугольника
            //            Console.WriteLine("Введите длину стороны a прямоугольника:");
            //            double a = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Введите длину стороны b прямоугольника:");
            //            double b = Convert.ToDouble(Console.ReadLine());
            //            double P = 2 * (a + b);
            //            Console.WriteLine($"Периметр прямоугольника: {P}");
            //            11.Вычисление длины окружности
            //            Console.WriteLine("Введите радиус окружности:");
            //            double R = Convert.ToDouble(Console.ReadLine());
            //            double L = 2 * Math.PI * R;
            //            Console.WriteLine($"Длина окружности: {L}");
            //            12.Расчет количества файлов, помещающихся на флэшку
            //            Console.WriteLine("Введите объем флэшки в Гб:");
            //            double flashDriveSizeGB = Convert.ToDouble(Console.ReadLine());
            //            double flashDriveSizeMB = flashDriveSizeGB * 1024;
            //            int fileSizeMB = 820;
            //            int fileCount = (int)(flashDriveSizeMB / fileSizeMB);
            //            Console.WriteLine($"На флэшку помещается {fileCount} файлов размером 820 Мб.");
            //            13.Вывод цифр двухзначного числа
            //            Console.WriteLine("Введите двухзначное число:");
            //            int number = Convert.ToInt32(Console.ReadLine());

            //            if (number < 10 || number > 99)
            //            {
            //                Console.WriteLine("Ошибка: Введено не двухзначное число.");
            //            }
            //            else
            //            {
            //                int tens = number / 10;
            //                int units = number % 10;
            //                Console.WriteLine($"Десятки: {tens}, Единицы: {units}");

            //                14.Вычислить значение функции при целых аргументах:
            //                Console.Write("x = ");
            //                int x = int.Parse(Console.ReadLine());
            //                double y = 0;
            //                if (x >= 0)
            //                {
            //                    y = Math.Sqrt(x) + 2 * Math.Sin(x);
            //                }
            //                else
            //                {
            //                    y = 6 - Math.Pow(x, 2);
            //                }
            //                Console.WriteLine(y); //Console. WriteLine($"y=(y:+2});
            //                15.Вычислить значение функции при вещественных аргументах:
            //                Console.Write("x =");
            //                int x = int.Parse(Console Readline());
            //                double f = 0;
            //                if (x <= -5)
            //                {
            //                    f = Math.Pow(x, 2) + 15 * x;
            //                }
            //                else if (x >= 5)
            //                {
            //                    f = 6 - Math.Pow(x, 2);
            //                }
            //                else
            //                {
            //                    f = Math.Sqrt(13 + x);
            //                }
            //                Console.WriteLine($”f”);
            //                16.Вычислить значение функции при целых аргументах:
            //                Console.Write("x = ");
            //                int x = int.Parse(Console.ReadLine());
            //                double f = 0;
            //                if (x >= 0)
            //                {
            //                    f = 2 + 3 * Math.Sqrt(x);
            //                }
            //                else
            //                {
            //                    f = 1 - 2 * Math.Pow(x, 2);
            //                }
            //                Console.WriteLine($”f”);
            //                17.Вычислить значение функции при вещественных аргументах:
            //                Console.Write("x =”);
            //                int x = int.Parse(Console.ReadLine());
            //                double f = 0;
            //                if (x <= -5)
            //                {
            //                    f = Math.Sqrt(13 - x);
            //                }
            //                else if (-5 < x && x < 5)
            //                {
            //                    f = Math.Abs((4 * x) - 5);
            //                }
            //                else
            //                {
            //                    f = 3 * Math.Pow(x, 2) - 5 *
            //                }
            //                Console.WriteLine($”f”);
            //                18.Увеличить или уменьшить число
            //        Console.WriteLine("Введите целое число:");
            //                int number = Convert.ToInt32(Console.ReadLine());

            //                if (number > 0)
            //                {
            //                    number += 1;
            //                }
            //                else
            //                {
            //                    number -= 2;
            //                }

            //                Console.WriteLine($"Результат: {number}");
            //                19.Изменить число в зависимости от его значения
            //        Console.WriteLine("Введите целое число:");
            //                int number = Convert.ToInt32(Console.ReadLine());

            //                if (number > 0)
            //                {
            //                    number += 1;
            //                }
            //                else if (number < 0)
            //                {
            //                    number -= 2;
            //                }
            //                else
            //                {
            //                    number = 10;
            //                }

            //                Console.WriteLine($"Результат: {number}");
            //                20.Определить знак числа
            //        Console.WriteLine("Введите целое число:");
            //                int number = Convert.ToInt32(Console.ReadLine());

            //                if (number > 0)
            //                {
            //                    Console.WriteLine("Число положительное.");
            //                }
            //                else if (number < 0)
            //                {
            //                    Console.WriteLine("Число отрицательное.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Число равно нулю.");
            //                }
            //                21.Проверка равностороннего треугольника
            //        Console.WriteLine("Введите стороны треугольника a, b, c:");
            //                double a = Convert.ToDouble(Console.ReadLine());
            //                double b = Convert.ToDouble(Console.ReadLine());
            //                double c = Convert.ToDouble(Console.ReadLine());

            //                if (a == b && b == c)
            //                {
            //                    Console.WriteLine("Треугольник равносторонний.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Треугольник не равносторонний.");
            //                }
            //                22.Проверка делимости числа на 3
            //        Console.WriteLine("Введите целое число:");
            //                int number = Convert.ToInt32(Console.ReadLine());

            //                if (number % 3 == 0)
            //                {
            //                    Console.WriteLine("Число является делителем числа 3.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Число не является делителем числа 3.");
            //                }
            //                23.Генерация случайных чисел и определение их знака
            //        Random random = new Random();

            //                for (int i = 0; i < 10; i++)
            //                {
            //                    int number = random.Next(-30, 31);
            //                    string sign = number > 0 ? "положительное" : "отрицательное";
            //                    Console.WriteLine($"{number} - {sign}");
            //                }
            //                24.Генерация случайных чисел и определение четности
            //                Random random = new Random();
            //                for (int i = 0; i < 8; i++)
            //                {
            //                    int number = random.Next(-20, 31);
            //                    string parity = number % 2 == 0 ? "чётное" : "нечётное";
            //                    Console.WriteLine($"{number} - {parity}");
            //                }
            //                25.Генерация положительных чисел и определение четности
            //                Random random = new Random();

            //                for (int i = 0; i < 10; i++)
            //                {
            //                    int number = random.Next(-20, 21);

            //                    if (number > 0)
            //                    {
            //                        string parity = number % 2 == 0 ? "четное" : "нечетное";
            //                        Console.WriteLine($"{number} - {parity}");
            //                    }
            //                }
            //                Найти максимальное число из двух целых чисел a и b
            //        int a = 15, b = 27;
            //                int max = Math.Max(a, b);
            //                Console.WriteLine("Максимальное число из " + a + " и " + b + " = " + max);

            //                День недели по номеру
            //        int n = 3; // например, для числа 3 будет "Среда"
            //                string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            //                if (n >= 1 && n <= 7)
            //                    Console.WriteLine("День недели под номером " + n + ": " + daysOfWeek[n - 1]);

            //                Вывод четных двузначных чисел
            //        Console.WriteLine("Четные двузначные числа:");
            //                for (int i = 10; i <= 99; i += 2)
            //                {
            //                    if (i % 2 == 0)
            //                        Console.WriteLine(i);
            //                }

            //                Вывод нечетных двузначных чисел
            //    Console.WriteLine("Нечетные двузначные числа:");
            //                for (int i = 11; i <= 99; i += 2)
            //                {
            //                    if (i % 2 != 0)
            //                        Console.WriteLine(i);
            //                }

            //                Вывод "Привет!" десять раз в столбик
            //for (int i = 0; i < 10; i++)
            //                {
            //                    Console.WriteLine("Привет!");
            //                }

            //                Вывод "Информатика" n раз в столбик
            //n = 5; // например, выводим 5 раз
            //                for (int i = 0; i < n; i++)
            //                {
            //                    Console.WriteLine("Информатика");
            //                }

            //                Вывод первых пяти натуральных чисел в столбик
            //Console.WriteLine("Первые пять натуральных чисел:");
            //                for (int i = 1; i <= 5; i++)
            //                {
            //                    Console.WriteLine(i);
            //                }

            //                Вывод горизонтальной строки из 18 символов
            //Console.WriteLine("Горизонтальная строка из 18 символов:");
            //                for (int i = 0; i < 18; i++)
            //                {
            //                    Console.Write("-");
            //                }
            //                Console.WriteLine(); // переход на новую строку после горизонтальной строки

            //                Вывод первых десяти натуральных чисел в обратном порядке
            //Console.WriteLine("Первые десять натуральных чисел в обратном порядке:");
            //                for (int i = 10; i >= 1; i--)
            //                {
            //                    Console.WriteLine(i);
            //                }

            //                Вывод горизонтальной строки из 18 символов с использованием любого вида цикла
            //Console.WriteLine("Горизонтальная строка из 18 символов (с использованием цикла):");
            //                string line = "";
            //                for (int i = 0; i < 18; i++)
            //                {
            //                    line += "-";
            //                }
            //                Console.WriteLine(line);

            //                Таблица значений функции y = 5x - 2 на отрезке[1; 20] с шагом h = 2
            //Console.WriteLine("Таблица значений функции y = 5x - 2:");
            //Console.WriteLine("x\t|\ty");
            //Console.WriteLine("---------------------");
            //for (int x = 1; x <= 20; x += 2)
            //{
            //    int y = 5 * x - 2;
            //    Console.WriteLine(x + "\t|\t" + y);
            //}


            //                Вывести на экран в строку следующие числа через цикл: 1 5 7 9 11
            //Console.WriteLine("Числа через цикл: 1 5 7 9 11");
            //                for (int i = 1; i <= 11; i += 2)
            //                {
            //                    Console.Write(i + " ");
            //                }
            //                Console.WriteLine(); // переход на новую строку

            //                Вывести на экран в строку следующие числа через цикл: 4 8 12 16 20
            //Console.WriteLine("Числа через цикл: 4 8 12 16 20");
            //                for (int i = 4; i <= 20; i += 4)
            //                {
            //                    Console.Write(i + " ");
            //                }
            //                Console.WriteLine(); // переход на новую строку

            //                Вывести двузначные натуральные числа, кратные 10
            //Console.WriteLine("Двузначные натуральные числа, кратные 10:");
            //                for (int i = 10; i <= 99; i += 10)
            //                {
            //                    Console.WriteLine(i);
            //                }

            //                Вывести на экран все целые числа от 100 до 200, кратные трем
            //Console.WriteLine("Целые числа от 100 до 200, кратные трем:");
            //                for (int i = 100; i <= 200; i += 3)
            //                {
            //                    Console.WriteLine(i);
            //                }

            //                Таблица стоимости товара(одна штука стоит 20.4 руб.) от 2 до 20 штук
            //Console.WriteLine("Таблица стоимости товара:");
            //                double pricePerUnit = 20.4;
            //                Console.WriteLine("Количество\t|\tСтоимость");
            //                Console.WriteLine("---------------------------------");
            //                for (int count = 2; count <= 20; count++)
            //                {
            //                    double totalCost = count * pricePerUnit;
            //                    Console.WriteLine(count + "\t\t|\t" + totalCost.ToString("F2") + " руб.");
            //                }

            //                Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20
            //Console.WriteLine("Ряд чисел 20:");
            //                for (int i = 0; i < 10; i++)
            //                {
            //                    Console.Write("20 ");
            //                }
            //                Console.WriteLine(); // переход на новую строку

            //                Таблица перевода долларов в рубли по текущему курсу(ввод курса с клавиатуры)
            //Console.WriteLine("Таблица перевода долларов в рубли:");
            //                Console.Write("Введите текущий курс доллара: ");
            //                double exchangeRate = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Доллары\t|\tРубли");
            //                Console.WriteLine("---------------------");
            //                for (int dollars = 1; dollars <= 20; dollars++)
            //                {
            //                    double rubles = dollars * exchangeRate;
            //                    Console.WriteLine(dollars + "\t|\t" + rubles.ToString("F2"));
            //                }

            //                Найти сумму чисел, кратных 5, в пределах от 0 до 1000
            //int sum = 0;
            //                for (int num = 0; num <= 1000; num += 5)
            //                {
            //                    sum += num;
            //                }
            //                Console.WriteLine("Сумма чисел, кратных 5, в пределах от 0 до 1000: " + sum);

            //                Напечатать ряд чисел 10 в виде: 10 10 10 10 10 10 10 10 10 10
            //Console.WriteLine("Ряд чисел 10:");
            //                for (int i = 0; i < 10; i++)
            //                {
            //                    Console.Write("10 ");
            //                }
            //                Console.WriteLine(); // переход на новую строку

            //                Вывести двузначные числа, кратные 11
            //Console.WriteLine("Двузначные числа, кратные 11:");
            //                for (int i = 11; i <= 99; i += 11)
            //                {
            //                    Console.WriteLine(i);
            //                }

            //                Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
            //            }
            //        }
            Console.ReadKey();

        }
    }
}
