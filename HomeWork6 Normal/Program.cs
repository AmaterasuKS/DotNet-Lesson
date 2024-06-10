//Немножко переделал :D
using System;

class Program
{
    enum HomeWork
    {
        nr1 = 1,
        nr2 = 2,
        nr3 = 3,
        nr4 = 4,
        nr5 = 5,
        nr6 = 6
    }
    static double Extent(double number, int extent)
                                                                      
    {
        double result = 1;

        if (extent < 0)
        {
            number = 1 / number;
            extent = -extent;
        }
        for (int i = 0; i < extent; i++)
        {
            result *= number;
        }
        return result;
    }                 //Действие подсчёта числа
    static int Sum(int start, int end)

    {
        int sum = 0;
        for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)         //Даём понять программе что нам нужна сумма от маленького до самого большого числа в диапазоне 
        {
            sum += i;                          //Суммируем
        }
        return sum;
    }                              //Функция суммы чисел
    static void DisplayCard(string[] cards, int number)
    {
        if (number >= 0 && number < cards.Length)
        {
            Console.WriteLine($"Карта: {cards[number]}");
        }
        else
        {
            Console.WriteLine("Ошибка. Неправильный номер карты.");
        }
    }
    static bool IsPerfectNumber(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        int sumOfDivisors = 1;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                if (i == number / i)
                {
                    sumOfDivisors += i;
                }
                else
                {
                    sumOfDivisors += i + number / i;
                }
            }
        }

        return sumOfDivisors == number;
    }
    static bool LuckyNumber(string number)

    {
        int firstSum = 0;
        int secondSum = 0;
        for (int i = 0; i < 3; i++)
        {
            firstSum += number[i];   //Суммируем первые 3 цифры
        }
        Console.WriteLine($"Сумма первых 3 чисел = {firstSum}");
        for (int i = 3; i < 6; i++)
        {
            secondSum += number[i];       //Суммируем последние три цифры
        }
        Console.WriteLine($"Сумма вторых 3 чисел = {secondSum}");
        Console.WriteLine($"Сумма первых и вторых трёх чисел  {firstSum} = {secondSum}");
        return firstSum == secondSum;
    }                         //Проверяем является ли билетик счастливым
    static void Main()                                                //Просим у пользователя данные и выводим их
    {
        while (true)
        {

            try
            {
                Console.Clear();
                Console.WriteLine("Выберете homework от 1 до 6");
                HomeWork nr;
                nr = (HomeWork)int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case HomeWork.nr1:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Введите основание степени:");
                            double number = double.Parse(Console.ReadLine());

                            Console.WriteLine("Введите показатель степени:");
                            int extent = int.Parse(Console.ReadLine());

                            double result = Extent(number, extent);
                            Console.WriteLine($"Результат: {result}");
                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка: введите числовое значение.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Ошибка: введено слишком большое или слишком маленькое число.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        break;
                    case HomeWork.nr2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Введите первое число:");
                            int num1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе число:");
                            int num2 = int.Parse(Console.ReadLine());

                            int result = Sum(num1, num2);
                            Console.WriteLine($"Сумма чисел в диапазоне между {num1} и {num2} равна: {result}");
                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка: введите числовое значение.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Ошибка: введено слишком большое или слишком маленькое число.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        break;
                    case HomeWork.nr3:

                        try
                        {
                            Console.Clear();

                            Console.WriteLine("Введите начало интервала:");
                            int start = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите конец интервала:");
                            int end = int.Parse(Console.ReadLine());

                            Console.WriteLine($"осконали числа в интервале от {start} до {end}:");

                            for (int number = start; number <= end; number++)
                            {
                                if (IsPerfectNumber(number))
                                {
                                    Console.WriteLine(number);
                                }
                            }


                            Console.ReadLine();

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка: введите числовое значение.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Ошибка: введено слишком большое или слишком маленькое число.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        break;
                    case HomeWork.nr4:
                        try
                        {
                            Console.Clear();
                            {
                                string[] cards = { "2 черви", "3 черви", "4 черви", "5 черви", "6 бубны", "7 черви", "8 черви", "9 черви", "10 черви", "Валет черви", "Дама черви", "Король черви", "2 крести", "3 крести", "4 крести", "5 крести", "6 крести", "7 крести", "8 крести", "9 крести", "10 крести", "Валет крести", "Дама крести", "Король крести", "Туз крести", "2 бубны", "3 бубны", "4 бубны", "5 бубны", "6 бубны", "7 бубны", "8 бубны", "9 бубны", "10 бубны", "Валет бубны", "Дама бубны", "Король бубны", "Туз бубны", "2 пик", "3 пик", "4 пик", "5 пик", "6 пик", "7 пик", "8 пик", "9 пик", "10 пик", "Валет пик", "Дама пик", "Король пик", "Туз пик" };
                                Console.WriteLine("Введите порядковый номер карты (начиная с 0):");
                                int number = int.Parse(Console.ReadLine());
                                DisplayCard(cards, number);
                                Console.ReadLine();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка: введите числовое значение.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        break;
                    case HomeWork.nr5:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Введите шестизначное число:");
                            string ticket = Console.ReadLine();
                            if (ticket.Length != 6)
                            {
                                Console.WriteLine("Ошибка: введите шестизначное число.");
                                return;
                            }
                            if (LuckyNumber(ticket))
                            {
                                Console.WriteLine("Число является счастливым!");
                            }
                            else
                            {
                                Console.WriteLine("Число не является счастливым.");
                            }
                            Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Произошла ошибка: " + ex.Message);
                        }
                        break;
                    case HomeWork.nr6:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Введите число:");
                            int Value = int.Parse(Console.ReadLine());                                       //Просим ввести число
                            Console.WriteLine("Введите количество строк массива:");                          //Просим строки
                            int rows = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите количество столбцов массива:");                       //Просим столбцы
                            int columns = int.Parse(Console.ReadLine());

                            int[,] array = new int[rows, columns];                                           //Создаём новый массив с указанными данными

                            int Value2 = Value;
                            for (int i = 0; i < rows; i++)                                                   //С каждым разом наше число будет увеличиваться на 1
                            {
                                for (int j = 0; j < columns; j++)
                                {
                                    array[i, j] = Value2;
                                    Value2++;
                                }
                            }

                            Console.WriteLine("Сформированный массив:");                                     //Выводим массив
                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < columns; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Произошла ошибка: " + ex.Message);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: введите числовое значение.");
            }

        }
    }
}