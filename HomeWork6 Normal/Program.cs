//TASK 1 

using System;

class Program
{
    static double Extent(double number, int extent)                    //Действие подсчёта числа 
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
    }

    static void Main()                        //Просим у пользователя данные и выводим их
    {
        try
        {
            Console.WriteLine("Введите основание степени:");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите показатель степени:");
            int extent = int.Parse(Console.ReadLine());

            double result = Extent(number, extent);
            Console.WriteLine($"Результат: {result}");
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
    }
}


//TASK 2

using System;

class Program
{
    static int Sum(int start, int end)               //Функция суммы чисел
    {
        int sum = 0;
        for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)         //Даём понять программе что нам нужна сумма от маленького до самого большого числа в диапазоне 
        {
            sum += i;                          //Суммируем
        }
        return sum;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            int result = Sum(num1, num2);
            Console.WriteLine($"Сумма чисел в диапазоне между {num1} и {num2} равна: {result}");
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
    }
}


//TASK 3

using System;

class Program
{
    static bool PerfectNumber(int number)     //Является число совершенным или нет
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                sum = +i;
            }
        }
        return sum == number;
    }
    static void PerfectNumberInRange(int start, int end) //Поиск всех совершенных чисел в диапазоне
    {
        Console.WriteLine($"Совершенные числа в диапазоне от {start} до {end}: ");
        for (int i = start; i <= end; i++)
        {
            if (PerfectNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число диапазона: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число диапазона: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("Ошибка. Первое число диапазона не может быть больше чем последнее");
                return;
            }
            PerfectNumberInRange(start, end);

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
    }
}


//TASK 4


using System;
using System.Reflection;

class Program
{
    static void DisplayCard(string[] cards, int number)
    {
        try
        {


            if (number >= 0 && number < cards.Length)
            {
                Console.WriteLine($"Карта: {cards[number]}");
            }
            else
            {
                Console.WriteLine("Ошибка. Неправильный номер карты.");
            }

            static void Main()
            {
                string[] cards = { "2 черви", "3 черви", "4 черви", "5 черви", "6 бубны", "7 черви", "8 черви", "9 черви", "10 черви", "Валет черви", "Дама черви", "Король черви", "2 крести", "3 крести", "4 крести", "5 крести", "6 крести", "7 крести", "8 крести", "9 крести", "10 крести", "Валет крести", "Дама крести", "Король крести", "Туз крести", "2 бубны", "3 бубны", "4 бубны", "5 бубны", "6 бубны", "7 бубны", "8 бубны", "9 бубны", "10 бубны", "Валет бубны", "Дама бубны", "Король бубны", "Туз бубны", "2 пик", "3 пик", "4 пик", "5 пик", "6 пик", "7 пик", "8 пик", "9 пик", "10 пик", "Валет пик", "Дама пик", "Король пик", "Туз пик" };
                Console.WriteLine("Введите порядковый номер карты (начиная с 0):");
                int number = int.Parse(Console.ReadLine());
                DisplayCard(cards, number);
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
    }
}


//TASK 5

using System;

class Program
{
    static void Main()
    {
        try
        {
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
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
    static bool LuckyNumber(string number)         //Провреряем является ли билетик счастливым
    {
        int firstSum = 0;
        int secondSum = 0;
        for (int i = 0; i < 3; i++)
        {
            firstSum += number[i];  //Суммируем первые 3 цифры
        }
        Console.WriteLine($"Сумма первых 3 чисел = {firstSum}");
        for (int i = 3; i < 6; i++)
        {
            secondSum += number[i];       //Суммируем последние три цифры
        }
        Console.WriteLine($"Сумма вторых 3 чисел = {secondSum}");
        Console.WriteLine($"Сумма первых и вторых трёх чисел  {firstSum} = {secondSum}");
        return firstSum == secondSum;
    }
}


//ADDITIONAL TASK


using System;

class Program
{
    static void Main()
    {
        try
        {           
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
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}