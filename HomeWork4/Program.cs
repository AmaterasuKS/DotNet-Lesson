//TASK_1
//Калькулятор задание не плохое, мне понравилось. Сделал похожим методом как у вас на занятии, но чучуть изменил некоторые моменты и добавил функцию подсчета %

//using System.Text;
//class Program
//{
//    enum Operations
//    {
//        Plus = '+',
//        Minus = '-',
//        Multi = '*',
//        Division = '/',
//        Percentage = '%'
//    }
//    static void Main()
//    {
//        try
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.Write("Введите первое число: ");
//            var num1 = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите второе число: ");
//            var num2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Выберите операцию (+ - * / %):");
//            var operation = (Operations)Convert.ToChar(Console.ReadLine() ?? string.Empty);

//            switch (operation)
//            {
//                case Operations.Plus:
//                    Console.WriteLine($"{num1} {(char)operation} {num2} = {num1 + num2}");
//                    break;
//                case Operations.Minus:
//                    Console.WriteLine($"{num1} {(char)operation} {num2} = {num1 - num2}");
//                    break;
//                case Operations.Multi:
//                    Console.WriteLine($"{num1} {(char)operation} {num2} = {num1 * num2}");
//                    break;
//                case Operations.Division:
//                    Console.WriteLine($"{num1} {(char)operation} {num2} = {num1 / num2}");
//                    break;
//                case Operations.Percentage:
//                    double perc = (num1 * num2) / 100;
//                    Console.WriteLine($"{num1} {(char)operation} {num2} = {perc}");
//                    break;
//                default:
//                    Console.WriteLine("Неизвестное математическое действие.");
//                    break;
//            }
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine(ex.Message);
//            Console.WriteLine("Не дели на ноль!");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine(ex.Message);
//            Console.WriteLine("Неизвестный формат данных!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            Console.WriteLine("Неизвестная ошибка!");
//        }
//    }
//}


//TASK_2

using System;
using System.Collections.Generic;

class Program
{
    enum Pizza
    {
        Margherita = 1,
        Pepperoni,
        Hawaiian,
        Veggie
    }

    enum Drink
    {
        Water = 1,
        Soda,
        Juice
    }
    static void Main()
    {
        try
        {
            var pizzaPrices = new double[]                         //Создал массив для хранения цен напитков и пиццы
            {
            0.0, // Для значения 0 что сохранить
            8.0, // Margherita
            10.0, // Pepperoni
            9.0, // Hawaiian
            7.0 // Veggie
            };

            var drinkPrices = new double[]
            {
            0.0, //Для значения 0 что сохранить
            1.0, // Вода
            2.5, // Газировка
            3.0 // Сок
            };

            double totalAmount = 0;
            string[] orderDetails = new string[100];                                //Создал еще 1 массив на 100 строк для того чтобы хранить информацию о всем заказе в нем
            int orderIndex = 0;

            Console.WriteLine("Меню пиццы:");
            for (int i = 1; i < pizzaPrices.Length; i++)                            //Предлагаю клиенту меню
            {
                Console.WriteLine($"{i}. {(Pizza)i} - ${pizzaPrices[i]}");
            }
            Console.WriteLine("Введите код пиццы и количество :");
            Console.Write("Код пиццы: ");
            int pizzaCode = int.Parse(Console.ReadLine());
            if (pizzaCode > 4 || pizzaCode < 0)
            {
                Console.WriteLine("Введите допустимый код пиццы.");                 //Вывожу ошибку в случае неудачной попытки ввести код
                Console.Write("Код пиццы: ");
            }
            if (pizzaCode == 0)
            {
                return;
            }
            Console.Write("Количество: ");                                          //Сколько хотим взять
            int quantity = int.Parse(Console.ReadLine());
            if (quantity <= 0)
            {
                Console.WriteLine("Введите допустимое количество.");
                Console.Write("Количество: ");
            }
            Pizza selectedPizza = (Pizza)pizzaCode;
            int FullQuantity = quantity + quantity / 5;                //Так как каждая 5 пицца в подарок я решил записать именно так
            double cost = pizzaPrices[pizzaCode] * FullQuantity;
            orderDetails[orderIndex++] = $"{selectedPizza} - {quantity} шт. + {quantity / 5} шт. в подарок - ${cost}";       //Вывожу полную инфу
            totalAmount += cost;          //Подсчитываем

            Console.WriteLine("Меню напитков:");                         //Предлагаю меню напитков
            for (int i = 1; i < drinkPrices.Length; i++)
            {
                Console.WriteLine($"{i}. {(Drink)i} - ${drinkPrices[i]}");
            }
            Console.WriteLine("Введите код напитка и количество :");
            Console.Write("Код напитка: ");
            int drinkCode = int.Parse(Console.ReadLine());
            if (drinkCode > 3 || drinkCode < 0)
            {
                Console.WriteLine("Введите допустимый код напитка.");
                Console.Write("Код напитка: ");
            }
            if (drinkCode == 0)
            {
                return;
            }
            Console.Write("Количество: ");
            int quantity1 = int.Parse(Console.ReadLine());
            if (quantity1 <= 0)
            {
                Console.WriteLine("Введите допустимое количество.");
                Console.Write("Количество: ");
            }
            Drink selectedDrink = (Drink)drinkCode;
            double drinkCost = drinkPrices[drinkCode] * quantity1;
            if (drinkPrices[drinkCode] > 2 && quantity1 > 3)
            {
                drinkCost *= 0.85;                                                 //Если больше 3 напитков стоимостью больше чем 2$ то скидка 15%
            }
            orderDetails[orderIndex++] = $"{selectedDrink} - {quantity1} шт. - ${drinkCost}";
            totalAmount += drinkCost;
            if (totalAmount > 50)
            {
                totalAmount *= 0.8;                                                //Если общий заказ составил больше 50$ то скидка  20%
            }
            Console.WriteLine("\nЧек для оплаты:");
            for (int i = 0; i < orderIndex; i++)
            {
                Console.WriteLine(orderDetails[i]);
            }

            Console.WriteLine($"\nИтого к оплате: ${totalAmount}");                 //Ну и выводим весь чек

        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла неизвестная ошибка:");
            Console.WriteLine(ex.Message);
        }

    }
}
