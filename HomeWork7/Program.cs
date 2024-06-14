using System;

class Program
{
    enum HomeWork
    {
        nr1 = 1
    }
    static void BubbleSort(int[] massive)               // Сортируем массив методом пузырьковой сортировки
    {
        int n = massive.Length;                          //Делаем переменную массива
        for (int i = 0; i < n - 1; i++)                // Делаем сортировку для всех элементов массива
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (massive[j] > massive[j + 1])         // Здесь мы делаем так, что если текущее число больше следующего то мы меняем их местами. Здесь думаю все строки обьяснять не стоит, так как похожее задание было с символами.
                {
                    int symbol = massive[j];
                    massive[j] = massive[j + 1];
                    massive[j + 1] = symbol;
                }
            }
        }
    }
    static void PrintArray(int[] massive)        // Обычный метод для вывода массива в консоль
    {
        foreach (int num in massive)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Выберете домашнее задание(Пока что только 1 :D): ");
                HomeWork nr;
                nr = (HomeWork)int.Parse(Console.ReadLine());

                switch (nr){
                    case HomeWork.nr1:
                        try
                        {
                            int[] numbers = new int[30];        //массив на 30 значений
                            Random rand = new Random();         //Рандомайзер

                           
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i] = rand.Next(1, 101);              //Выводим рандомные числа от 1 до 100 (101 не учитывается, это точка конечного пункта)
                            }

                            
                            Console.WriteLine("Массив до сортировки:");      //Показываем наш массив до сортировки
                            PrintArray(numbers);

                           
                            BubbleSort(numbers);                              //Применяем сортировку пузырька

                            
                            Console.WriteLine("Массив после сортировки:");    //Выводим массив после сортировки
                            PrintArray(numbers);
                        }
                        catch (FormatException)                               //Делаем исключения
                        {
                            Console.WriteLine("Ошибка: неверный формат данных.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        break;
                }
            }
            catch (FormatException)                //Ещё исключения
            {
                Console.WriteLine("Неверный формат данных.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
