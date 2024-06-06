//Task 1 

using System;

class Program
{
    static void Main()
    {
        try
        {
            double[] profits = new double[6];
            double total = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Введите прибыль за месяц {i + 1}: ");
                profits[i] = double.Parse(Console.ReadLine());
                total += profits[i];
            }

            double average = total / 6;

            Console.WriteLine($"Общая прибыль за 6 месяцев: {total}");
            Console.WriteLine($"Средняя прибыль за месяц: {average}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение прибыли.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
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
            double[] profits = new double[12];
            string[] months = {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите прибыль за {months[i]}: ");
                profits[i] = double.Parse(Console.ReadLine());
            }

            double max = profits[0];
            double min = profits[0];
            int maxMonthIndex = 0;
            int minMonthIndex = 0;

            for (int i = 1; i < 12; i++)
            {
                if (profits[i] > max)
                {
                    max = profits[i];
                    maxMonthIndex = i;
                }

                if (profits[i] < min)
                {
                    min = profits[i];
                    minMonthIndex = i;
                }
            }

            Console.WriteLine($"Максимальная прибыль была в {months[maxMonthIndex]} и составила {max}");
            Console.WriteLine($"Минимальная прибыль была в {months[minMonthIndex]} и составила {min}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение прибыли.");
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
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите размер массива:");
            int size = int.Parse(Console.ReadLine());
            int[] symbols = new int[size];

            Console.WriteLine("Введите числа которые будут в данном массиве:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите число {i + 1}:");
                symbols[i] = int.Parse(Console.ReadLine());
            }

            int[] newMassive = new int[size];
            int NEW = 0;

            for (int i = 0; i < size; i++)
            {
                if (symbols[i] != 0)
                {
                    newMassive[NEW] = symbols[i];
                    NEW++;
                }
            }
            for (int i = NEW; i < size; i++)
            {
                newMassive[i] = -1;
            }
            Console.WriteLine("Изменённый массив: ");
            for (int i = 0; i < newMassive.Length; i++)
            {
                Console.WriteLine(newMassive[i] + " ");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}


//TASK 4


using System;

class Program
{
    static void Main()
    {
        try
        {
            Random rand = new Random();   //Подключаем рандомайзер
            int[,] matrix = new int[10, 10];             //Создаем нашу матрицу 10 на 10

            for (int start = 0; start < 10; start++)
            {
                for (int end = 0; end < 10; end++)
                {
                    matrix[start, end] = rand.Next(10, 100);       //Заполняем нашу матрицу рандомными цифрами
                }
            }

            Console.WriteLine("Матрица:");
            for (int start = 0; start < 10; start++)
            {
                for (int end = 0; end < 10; end++)
                {
                    Console.Write(matrix[start, end] + "\t");            //Выводим нашу матрицу
                }
                Console.WriteLine();
            }
            int mainDiagonal = 0;                                  //Берём главную диагональ и даем ей значение 0
            for (int i = 0; i < 10; i++)
            {
                mainDiagonal += matrix[i, i];                     //Делаем подсчёт всех чисел в главной диагонали
            }
            Console.WriteLine("Сумма чисел главной диагонали: " + mainDiagonal);        //Выводим


            int minDiagonal = int.MaxValue;
            int maxDiagonal = int.MinValue;
            for (int i = 0; i < 10; i++)                 //Находим Минимальное и Максимальное значение в побочной диагонали 
            {
                int value = matrix[i, 9 - i];
                if (value < minDiagonal) minDiagonal = value;
                if (value > maxDiagonal) maxDiagonal = value;
            }
            Console.WriteLine($"Минимальное значение побочной диагонали: {minDiagonal}");
            Console.WriteLine($"Максимальное значение побочной диагонали: {maxDiagonal}");        //Выводим


            Console.Write("Введите номер столбца (0-9): ");                  //Просим ввести номер столбца
            int columnnumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Столбец {columnnumber}:");
            for (int i = 0; i < 10; i++)                                     //Находим её
            {
                Console.WriteLine(matrix[i, columnnumber]);                  //Выводим её
            } 


            Console.Write("Введите номер строки (0-9): ");                   //Просим ввести номер строки
            int rownumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Строка {rownumber} +:");
            for (int j = 0; j < 10; j++)                                     //Находим строку
            {
                Console.Write(matrix[rownumber, j] + "\t");                  // Выводим через пробел
            }
            Console.WriteLine();


            Console.Write("Введите номер первого столбца который хотите изменить (0-9): ");
            int column1 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер второго столбца который хотите изменить (0-9): ");
            int column2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)                                      //Меняем столбцы местами
            {
                int temp = matrix[i, column1];
                matrix[i, column1] = matrix[i, column2];
                matrix[i, column2] = temp;
            }
            Console.WriteLine("Матрица после изменения столбцов:");           //Выводим уже изменённую матрицу
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write("Введите номер одной строки (0-9): ");             //Ну здесь тоже самое что и для столбца, просто меняем местами ряд и выводим изменённую матрицу
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер другой строки (0-9): ");
            int row2 = int.Parse(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                int temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }
            Console.WriteLine("Матрица после изменения строк:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка:  {ex.Message}");
        }
    }
}