using System;
using System.Collections.Generic;
using System.Threading.Tasks;
class List
{
    static List<string> tasks = new List<string>();
    enum HomeWork
    {
        nr1 = 1
    }
    static void AddTask()
    {
        Console.Write("Введите задание: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Задание добавлено.");
    }
    static void EditTask()
    {
        ViewTasks();
        Console.Write("Введите индекс задания для изменения: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < tasks.Count)
        {
            Console.Write("Введите новое задание: ");
            string newTask = Console.ReadLine();
            tasks[index ] = newTask;
            Console.WriteLine("Задание изменено.");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }
    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("Введите индекс задания для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index );
            Console.WriteLine("Задание удалено.");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }
    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список заданий пуст.");
        }
        else
        {
            Console.WriteLine("Список заданий:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {tasks[i]}");
            }
        }
    }
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Выберете домашнее задание(Только 1 :D): ");
                HomeWork nr;
                nr = (HomeWork)int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case HomeWork.nr1:
                        try
                        {
                            bool exit = false;

                            while (!exit)
                            {
                                Console.WriteLine("\nМеню:");
                                Console.WriteLine("1. Добавить задания");
                                Console.WriteLine("2. Изменить задания");
                                Console.WriteLine("3. Удалить задания");
                                Console.WriteLine("4. Просмотреть задания");
                                Console.WriteLine("5. Выйти");
                                Console.Write("Выбрать опцию: ");
                                string choice = Console.ReadLine();

                                switch (choice)
                                {
                                    case "1":
                                        AddTask();
                                        break;
                                    case "2":
                                        EditTask();
                                        break;
                                    case "3":
                                        DeleteTask();
                                        break;
                                    case "4":
                                        ViewTasks();
                                        break;
                                    case "5":
                                        exit = true;
                                        break;
                                    default:
                                        Console.WriteLine("Неверный выбор, попробуйте ещё раз.");
                                        break;
                                }
                            }
                        }
                        catch (FormatException)                //Исключения
                        {
                            Console.WriteLine("Неверный формат данных.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        }
                        Console.ReadLine();
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