//Task 1
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите начало диапазона: ");       //Вводим начало диапазона
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите конец диапазона: ");        //Вводим конец диапазона
            int end = int.Parse(Console.ReadLine());
            if (start > end)
            {
                Console.WriteLine("Начало диапазона должно быть меньше или равно концу диапазона.");          //Выдаем ошибку в случае если пользователь ввел начальный диапазон больше конечного
                return;
            }
            Console.WriteLine("\nВсе числа в диапазоне:");                   //Выводим все числа диапазона ОТ и ДО
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nВсе числа в диапазоне в обратном порядке:");       //Так же выводим все числа в обратном порядке
            for (int i = end; i >= start; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nВсе числа, кратные 7:");                           //Таким же способом выводим все числа которые кратные 7
            for (int i = start; i <= end; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            int On5 = 0;                                               //Так же и с числами кратные 5
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    On5++;
                }
            }
            Console.WriteLine($"\n\nКоличество чисел, кратных 5: {On5}");
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR.\nНеверный формат данных.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}

//Task 2

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int end = int.Parse(Console.ReadLine());
            int sum0 = 0;                             //Создал переменные в которых буду хранить результаты
            int sum1 = 0;
            int count0 = 0;
            int count1 = 0;
            int sumM9 = 0;
            int countM9 = 0;

            if (start > end)
            {
                Console.WriteLine("Начало диапазона должно быть меньше или равно концу диапазона.");                //Выдаем ошибку если начало больше конца
                return;
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)              //Сумма если число парное
                {
                    sum0 += i;
                    count0++;
                }
                else                         //Если непарное
                {
                    sum1 += i;
                    count1++;
                }

                if (i % 9 == 0)              //Кратное 9
                {
                    sumM9 += i;
                    countM9++;
                }
            }
            Console.WriteLine($"\nСумма четных чисел: {sum0}");
            if (count0 > 0)
            {
                Console.WriteLine($"Среднее арифметическое четных чисел: {(double)sum0 / count0}");
            }
            else
            {
                Console.WriteLine("Среднее арифметическое четных чисел: отсутствуют четные числа");
            }

            Console.WriteLine($"\nСумма нечетных чисел: {sum1}");
            if (count1 > 0)
            {
                Console.WriteLine($"Среднее арифметическое нечетных чисел: {(double)sum1 / count1}");
            }
            else
            {
                Console.WriteLine("Среднее арифметическое нечетных чисел: отсутствуют нечетные числа");
            }

            Console.WriteLine($"\nСумма чисел, кратных 9: {sumM9}");
            if (countM9 > 0)
            {
                Console.WriteLine($"Среднее арифметическое чисел, кратных 9: {(double)sumM9 / countM9}");
            }
            else
            {
                Console.WriteLine("Среднее арифметическое чисел, кратных 9: отсутствуют числа, кратные 9");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Введите допустимое числовое значение.{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}

//Additional Tasks

//Task 1

class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 100; i <= 999; i++)
        {
            int STO = i / 100;                                 //Перевёл все цифры в числа для упрощения
            int DESYAT = (i / 10) % 10;
            int ODIN = i % 10;

            if (STO == DESYAT || STO == ODIN || DESYAT == ODIN)              //Дал условие при котором числа будут сравниваться, и если будут сходства - пойдет подсчёт
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел с двумя одинаковыми цифрами в диапазоне от 100 до 999: {count}");
    }
}


//Task 2

using System;

class Program
{
    static void Main()
    {
        try
        {


            Console.Write("Введите начальное число диапазона: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное число диапазона: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Простые числа в диапазоне от {start} до {end}:");

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Введено некорректное число.{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;             //Если число меньше либо равняется 1, то оно не является простым
        if (number == 2) return true;              //Если же число равняется 2, то оно является простым так как делится только на себя и на 1
        if (number % 2 == 0) return false;         //Если же число делится на 2(парное), то оно не является простым

        for (int i = 3; i <= Math.Sqrt(number); i += 2)        //Это для непарных чисел, так как на парные числа проверка уже есть(по-этому шаг проверки равен +=2). 
        {                                                      //Если в кратце то здесь будет проверка делимости на 3 до квадратного корня каждого вписанного числа. И если оно поделится без остатка, то это будет не простым числом
            if (number % i == 0) return false;
        }

        return true;                                            //Во всех же остальных случаях, это будут простые числа.
    }
}