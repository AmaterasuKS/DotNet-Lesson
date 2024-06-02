

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum pizza1_enum
        {
            pizza1 = 1,
            pizza2 = 2,
            pizza3 = 3,
            pizza4 = 4
        }
        enum drink_enum
        {
            drink1 = 1,
            drink2 = 2,
            drink3 = 3
        }
        static void Main(string[] args)
        {
            ////Everything related to pizza
            string pizza1 = "Четыри сыра ";
            string pizza2 = "Пиперони    ";
            string pizza3 = "Маргарита   ";
            string pizza4 = "Афинская    ";

            pizza1_enum pizza;
            int number_of_pizza_first = 0;
            int quantity_of_second_pizza = 0;
            int number_of_thirds_pizza = 0;
            int quantity_of_fourth_pizza = 0;

            int оtotal_number_of_pizzas = 0;

            int bonus_pizza_1 = 0;
            int bonus_pizza_2 = 0;
            int bonus_pizza_3 = 0;
            int bonus_pizza_4 = 0;

            int counting_bonus_pizzas;

            int tsykol_1_pizza = 0;
            int tsykol_2_pizza = 0;

            int choice_action2_pizza;

            decimal pizza_price_1 = 5;
            decimal pizza_price_2 = 5;
            decimal pizza_price_3 = 5;
            decimal pizza_price_4 = 5;
            decimal counting_pizza_valuable = 0;//==

            //Everything related to drinks
            int tsykol_1_drinks = 0;
            int tsykol_2_drinks = 0;
            int choice_actions2_drinks;

            decimal value_of_drink_1 = 1;
            decimal value_of_drink_2 = 1;
            decimal value_of_drink_3 = 2;

            decimal result_number_of_drinks_with_discount = 0;

            drink_enum drink;
            int quantity_drink1 = 0;
            int quantity_drink2 = 0;
            int quantity_drink3 = 0;

            int total_number_of_drinks = 0;

            decimal counting_drinks_valuable;
            decimal counting_drinks_price_with_discount;



            string drink1 = "Чай чёрный";
            string drink2 = "Coca Cola ";
            string drink3 = "Коньяк    ";
            //Everything related to the cycle3
            decimal Total_order_amount1 = 0;
            decimal Total_order_amount2 = 0;
            int action_choice = 0;

            decimal amount_of_drinks_without_discount = 0;
            decimal amount_of_drinks_with_discount = 0;
            //Everything that relates to "Пиццерия Итальяно"
            int action_selection1;
            int tsykol_third_my_order = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Условие dz №4  #2\r\n                " +
                                  "Написать программу, реализующую процедуры заказа и расчет его суммы в мини - пиццерии.\r\n                " +
                                  "В меню пиццерии предусмотрено 4 вида пиццы и 3 вида напитков.\r\n                " +
                                  "Пользователю выводится меню(первоначально пиццы, затем напитки), содержащее код и название.\r\n                " +
                                  "Пользователь вводит код желаемого продукта, затем вводит количество единиц продукта.\r\n                " +
                                  "В пиццерии предусмотрено два вида скидок:\r\n                " +
                                  "■ если общая сумма заказа больше 50$, то размер скидки составляет 20 % от суммы заказа;\r\n                " +
                                  "■ каждая пятая пицца – в подарок;\r\n                " +
                                  "■ для напитков с ценой более 2$, если количество в заказе больше трех, то скидка 15 % \n                " +
                                  "(только на напитки, а не на все заказы).\r\n                " +
                                  "Вывести пользователю «чек» для оплаты в виде: название – количество – цена.\r\n                " +
                                  "Вместе к оплате.\n\n");
                try
                {
                    Console.WriteLine("Пиццерия Итальяно\n" +
                                 "═══════════════════████ \r\n════════════════████══██ \r\n═══════════════███═════██════════█ \r\n═════════════███═════███════════██════█ \r\n═════════════██══════██═════════██═══██ \r\n═════════════████████████═══════███══██ \r\n═══════════════█══█████0██═══════███═███ \r\n══════════███████═█████████═══════██══███ \r\n═══════█████════██═███████═════════██══██ \r\n═════████════════█══████═══════════█════██ \r\n════██═════════█═██═█═══════════════════█ \r\n═══██══════════██═██ \r\n══██═════█══════███════════██═█████████████████ \r\n═██══════███═════████████████████═█══█══█══█═█████ \r\n██════════███═════════██═████████████████████████ \r\n██══════════███════════███████════████████ \r\n██════════════████═██████ \r\n██══════════════███████ \r\n██════════════════█ \r\n██════════════════█ \r\n███████████████████ \r\n███████████████████ \r\n═══█══════██═══█ \r\n═══██═════██═══█ \r\n═══██═════██═══█ \r\n═══██═════██═══███ \r\n═══█═══════██████████ \r\n═══███████████\n" +
                                 "Меню:\n" +
                                 "1)Пицца\n" +
                                 "2)Напитки\n" +
                                 "3)Мой заказ\n");

                    Console.WriteLine("Выберете действие :'1' '2' '3' ");
                    action_selection1 = int.Parse(Console.ReadLine());
                    if (action_selection1 == 1) ++tsykol_1_pizza;
                    else if (action_selection1 == 2) ++tsykol_1_drinks;
                    else if (action_selection1 == 3) ++tsykol_third_my_order;
                    else { Console.WriteLine("Ошибка!Укажите действие:'1' '2' '3'"); Console.ReadLine(); continue; }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!Укажите действие:'1' '2''3'"); Console.ReadLine(); continue;
                    throw;
                }


                for (int i = 1; i == tsykol_1_pizza; ++i)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine($"Меню \n" +
                                          $"Пицца :\n" +
                                          $"1){pizza1}\t   :Cтоимость={pizza_price_1}$\n" +
                                          $"░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░░░░░\r\n░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄░░░░░░█████▄░░░░░░\r\n░░░░░░░░░▄▄█████████████▀░░▄░░▀████▄░░░░\r\n░░░░░░▄▄███▀▀░░▄▄▄▄▄▄░░▀░░████▄░▀████░░░\r\n░░░░▄███▀░▄▄██████▀▀███░░▄█▀▀░▀▀▄░▀███▄░\r\n░░░▄██▀░▄███▀▀▀███▄▄██░░▄██░░░░░█▄░▀███░\r\n░░███░▄██████████████▀░░███▄░░░▄██▄░████\r\n░███░▄████░█████░▀██▀░░█████████▀▀▀░░░░░\r\n▄██░░██████▀▀███████░░▀▀▀▀▀░░░░░░░░░░░░░\r\n███░██████░░░░█████░░░░░░░░░▄▄▄▄░░██░░░░\r\n██░░██████▄░░▄█████▄▄▄█████▀▀███░░██░░░░\r\n███░███▄░▀█████▀▀███████████████░░██░░░░\r\n███░▀██████▀████▄▄█████▄▄███▀███░▄██░░░░\r\n░██▄░██████▄▄██████▀▀▀█████▄▄██░░██▀░░░░\r\n░▀██▄░▀█▀▀████████░░░░░███████░░██▀░░░░░\r\n░░▀██▄░▀███████████▄░▄▄█████▀░▄██▀░░░░░░\r\n░░░░▀██▄░░▀███▄▄▄████████▀▀░▄███▀░░░░░░░\r\n░░░░░░▀███▄░░▀▀▀▀▀▀▀▀▀▀░░▄▄███▀░░░░░░░░░\r\n░░░░░░░░▀▀████▄▄▄▄▄▄▄▄█████▀░░░░░░░░░░░░\r\n░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                                          $"Состав:сыр моцарелла, сыр твердый, мука пшеничная высшего сорта,\n " +
                                          $"мука из твердых сортов пшеницы, сыр дор блю, сметана, сливки,\n" +
                                          $" сыр пармезан, растительное масло, яйца куриные, смесь многофункциональная закваска,\n" +
                                          $"соль поваренная, сахар, специи(содержат гирицу)\n\n\n" +
                                          $"2){pizza2}\t   :Cтоимость={pizza_price_2}$\n" +
                                          $"░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░░░░░\r\n░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄░░░░░░█████▄░░░░░░\r\n░░░░░░░░░▄▄█████████████▀░░▄░░▀████▄░░░░\r\n░░░░░░▄▄███▀▀░░▄▄▄▄▄▄░░▀░░████▄░▀████░░░\r\n░░░░▄███▀░▄▄██████▀▀███░░▄█▀▀░▀▀▄░▀███▄░\r\n░░░▄██▀░▄███▀▀▀███▄▄██░░▄██░░░░░█▄░▀███░\r\n░░███░▄██████████████▀░░███▄░░░▄██▄░████\r\n░███░▄████░█████░▀██▀░░█████████▀▀▀░░░░░\r\n▄██░░██████▀▀███████░░▀▀▀▀▀░░░░░░░░░░░░░\r\n███░██████░░░░█████░░░░░░░░░▄▄▄▄░░██░░░░\r\n██░░██████▄░░▄█████▄▄▄█████▀▀███░░██░░░░\r\n███░███▄░▀█████▀▀███████████████░░██░░░░\r\n███░▀██████▀████▄▄█████▄▄███▀███░▄██░░░░\r\n░██▄░██████▄▄██████▀▀▀█████▄▄██░░██▀░░░░\r\n░▀██▄░▀█▀▀████████░░░░░███████░░██▀░░░░░\r\n░░▀██▄░▀███████████▄░▄▄█████▀░▄██▀░░░░░░\r\n░░░░▀██▄░░▀███▄▄▄████████▀▀░▄███▀░░░░░░░\r\n░░░░░░▀███▄░░▀▀▀▀▀▀▀▀▀▀░░▄▄███▀░░░░░░░░░\r\n░░░░░░░░▀▀████▄▄▄▄▄▄▄▄█████▀░░░░░░░░░░░░\r\n░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                                          $"Состав:Сыр моцарелла, колбаса пеперони, томаты в собственном соку,\n" +
                                          $" мука пшеничная высшего сорта, мука из твердых сортов пшеницы, \n" +
                                          $"смесь многофункциональная закваска, масло растительное, соль поваренная,\n" +
                                          $" сахар, специи (содержащие горчицу)\n\n\n" +
                                          $"3){pizza3}\t   :Cтоимость={pizza_price_3}$\n" +
                                          $"░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░░░░░\r\n░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄░░░░░░█████▄░░░░░░\r\n░░░░░░░░░▄▄█████████████▀░░▄░░▀████▄░░░░\r\n░░░░░░▄▄███▀▀░░▄▄▄▄▄▄░░▀░░████▄░▀████░░░\r\n░░░░▄███▀░▄▄██████▀▀███░░▄█▀▀░▀▀▄░▀███▄░\r\n░░░▄██▀░▄███▀▀▀███▄▄██░░▄██░░░░░█▄░▀███░\r\n░░███░▄██████████████▀░░███▄░░░▄██▄░████\r\n░███░▄████░█████░▀██▀░░█████████▀▀▀░░░░░\r\n▄██░░██████▀▀███████░░▀▀▀▀▀░░░░░░░░░░░░░\r\n███░██████░░░░█████░░░░░░░░░▄▄▄▄░░██░░░░\r\n██░░██████▄░░▄█████▄▄▄█████▀▀███░░██░░░░\r\n███░███▄░▀█████▀▀███████████████░░██░░░░\r\n███░▀██████▀████▄▄█████▄▄███▀███░▄██░░░░\r\n░██▄░██████▄▄██████▀▀▀█████▄▄██░░██▀░░░░\r\n░▀██▄░▀█▀▀████████░░░░░███████░░██▀░░░░░\r\n░░▀██▄░▀███████████▄░▄▄█████▀░▄██▀░░░░░░\r\n░░░░▀██▄░░▀███▄▄▄████████▀▀░▄███▀░░░░░░░\r\n░░░░░░▀███▄░░▀▀▀▀▀▀▀▀▀▀░░▄▄███▀░░░░░░░░░\r\n░░░░░░░░▀▀████▄▄▄▄▄▄▄▄█████▀░░░░░░░░░░░░\r\n░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                                          $"Состав:Сыр моцарелла, томаты в собственном соку, томаты свежие,\n" +
                                          $" мука пшеничная высшего сорта, мука из твердых сортов пшеницы, сыр моцарелла (мини),\n" +
                                          $" смесь многофункциональная закваска, масло растительное, соус свит чили, соль поваренная пищевая,\n" +
                                          $"сахар, специи (содержат горчицу)\n\n\n" +
                                          $"4){pizza4}\t   :Cтоимость={pizza_price_4}$\n" +
                                          $"░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░░░░░\r\n░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄░░░░░░█████▄░░░░░░\r\n░░░░░░░░░▄▄█████████████▀░░▄░░▀████▄░░░░\r\n░░░░░░▄▄███▀▀░░▄▄▄▄▄▄░░▀░░████▄░▀████░░░\r\n░░░░▄███▀░▄▄██████▀▀███░░▄█▀▀░▀▀▄░▀███▄░\r\n░░░▄██▀░▄███▀▀▀███▄▄██░░▄██░░░░░█▄░▀███░\r\n░░███░▄██████████████▀░░███▄░░░▄██▄░████\r\n░███░▄████░█████░▀██▀░░█████████▀▀▀░░░░░\r\n▄██░░██████▀▀███████░░▀▀▀▀▀░░░░░░░░░░░░░\r\n███░██████░░░░█████░░░░░░░░░▄▄▄▄░░██░░░░\r\n██░░██████▄░░▄█████▄▄▄█████▀▀███░░██░░░░\r\n███░███▄░▀█████▀▀███████████████░░██░░░░\r\n███░▀██████▀████▄▄█████▄▄███▀███░▄██░░░░\r\n░██▄░██████▄▄██████▀▀▀█████▄▄██░░██▀░░░░\r\n░▀██▄░▀█▀▀████████░░░░░███████░░██▀░░░░░\r\n░░▀██▄░▀███████████▄░▄▄█████▀░▄██▀░░░░░░\r\n░░░░▀██▄░░▀███▄▄▄████████▀▀░▄███▀░░░░░░░\r\n░░░░░░▀███▄░░▀▀▀▀▀▀▀▀▀▀░░▄▄███▀░░░░░░░░░\r\n░░░░░░░░▀▀████▄▄▄▄▄▄▄▄█████▀░░░░░░░░░░░░\r\n░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                                          $"Состав:Сыр моцарелла, томаты в собственном соку, мука пшеничная высшего сорта,\n" +
                                          $" мука из твердых сортов пшеницы, филе куриная охлаждение, грудинка свиная полукопченая,\n" +
                                          $" салями, лук зеленый, смесь многофункциональная закваска, масло растительное, соус мир чили,\n" +
                                          $" соль поваренная, сахар, специи (содержат гирицу)\n\n\n");
                        Console.WriteLine("Выберете пиццу указав индекс :1,2,3,4");
                        pizza = (pizza1_enum)int.Parse(Console.ReadLine());
                        switch (pizza)
                        {
                            case Program.pizza1_enum.pizza1:
                                Console.WriteLine("укажите количество:");
                                number_of_pizza_first = int.Parse(Console.ReadLine());

                                if (number_of_pizza_first >= 4)
                                {
                                    for (int р = 4; р <= number_of_pizza_first; р += 4)
                                    {
                                        ++bonus_pizza_1;
                                    }
                                }
                                tsykol_2_pizza++;
                                break;
                            case Program.pizza1_enum.pizza2:
                                Console.WriteLine("укажите количество:");
                                quantity_of_second_pizza = int.Parse(Console.ReadLine());
                                if (quantity_of_second_pizza >= 4)
                                {
                                    for (int р = 4; р <= quantity_of_second_pizza; р += 4)
                                    {
                                        ++bonus_pizza_2;
                                    }
                                }
                                tsykol_2_pizza++;
                                break;
                            case Program.pizza1_enum.pizza3:
                                Console.WriteLine("укажите количество:");
                                number_of_thirds_pizza = int.Parse(Console.ReadLine());
                                if (number_of_thirds_pizza >= 4)
                                {
                                    for (int р = 4; р <= number_of_thirds_pizza; р += 4)
                                    {
                                        ++bonus_pizza_3;
                                    }
                                }
                                tsykol_2_pizza++;
                                break;
                            case Program.pizza1_enum.pizza4:
                                Console.WriteLine("укажите количество:");
                                quantity_of_fourth_pizza = int.Parse(Console.ReadLine());
                                if (quantity_of_fourth_pizza >= 4)
                                {
                                    for (int р = 4; р <= quantity_of_fourth_pizza; р += 4)
                                    {
                                        ++bonus_pizza_4;
                                    }
                                }
                                tsykol_2_pizza++;
                                break;
                            default:
                                Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4"); Console.ReadLine(); --i;
                                break;
                        }
                        оtotal_number_of_pizzas = number_of_pizza_first + quantity_of_second_pizza + number_of_thirds_pizza + quantity_of_fourth_pizza;
                        if (оtotal_number_of_pizzas > 0)
                        {
                            Console.WriteLine("\nДобавленно в корзину:");
                            if (number_of_pizza_first > 0 && bonus_pizza_1 > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:+{bonus_pizza_1}шт бонусная пицца\t     " + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                            else if (number_of_pizza_first > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:" + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                            if (quantity_of_second_pizza > 0 && bonus_pizza_2 > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:+{bonus_pizza_2}шт бонусная пицца\t     " + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                            else if (quantity_of_second_pizza > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                            if (number_of_thirds_pizza > 0 && bonus_pizza_3 > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:+{bonus_pizza_3}шт бонусная пицца\t     " + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                            else if (number_of_thirds_pizza > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:" + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                            if (quantity_of_fourth_pizza > 0 && bonus_pizza_4 > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:+{bonus_pizza_4}+шт бонусная пицца" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");
                            else if (quantity_of_fourth_pizza > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");

                            counting_bonus_pizzas = bonus_pizza_1 + bonus_pizza_2 + bonus_pizza_3 + bonus_pizza_4;
                            counting_pizza_valuable = (number_of_pizza_first * pizza_price_1) +
                                                (quantity_of_second_pizza * pizza_price_2) +
                                                (number_of_thirds_pizza * pizza_price_3) +
                                                (quantity_of_fourth_pizza * pizza_price_4);

                            Console.WriteLine($"Общая цена ={counting_pizza_valuable}");
                        }
                        else
                        {
                            Console.WriteLine("В корзине нечего нет:\n" +
                                              "Корзина очищена :");
                            number_of_pizza_first = 0;
                            quantity_of_second_pizza = 0;
                            number_of_thirds_pizza = 0;
                            quantity_of_fourth_pizza = 0;

                            оtotal_number_of_pizzas = 0;

                            bonus_pizza_1 = 0;
                            bonus_pizza_2 = 0;
                            bonus_pizza_3 = 0;
                            bonus_pizza_4 = 0;

                            counting_pizza_valuable = 0;

                            counting_bonus_pizzas = 0;

                        }
                        for (int j = 1; j == tsykol_2_pizza; ++j)
                        {
                            try
                            {
                                Console.WriteLine("\n" +
                                     "Продолжить заказывать     нажмите:1\n" +
                                     "Оформить заказ            нажмите:2\n" +
                                     "Отменить всё и выйти      нажмите:3\n" +
                                     "Отменить всё и продолжить нажмите:4");

                                choice_action2_pizza = int.Parse(Console.ReadLine());
                                if (choice_action2_pizza == 1) { tsykol_2_pizza = 0; tsykol_1_pizza++; }
                                if (choice_action2_pizza == 2) { tsykol_2_pizza = 0; tsykol_1_pizza = 0; }
                                if (choice_action2_pizza == 3)
                                {
                                    number_of_pizza_first = 0;
                                    quantity_of_second_pizza = 0;
                                    number_of_thirds_pizza = 0;
                                    quantity_of_fourth_pizza = 0;

                                    оtotal_number_of_pizzas = 0;

                                    bonus_pizza_1 = 0;
                                    bonus_pizza_2 = 0;
                                    bonus_pizza_3 = 0;
                                    bonus_pizza_4 = 0;

                                    counting_pizza_valuable = 0;
                                    counting_bonus_pizzas = 0;

                                    tsykol_2_pizza = 0; tsykol_1_pizza = 0;
                                }
                                if (choice_action2_pizza == 4)
                                {
                                    number_of_pizza_first = 0;
                                    quantity_of_second_pizza = 0;
                                    number_of_thirds_pizza = 0;
                                    quantity_of_fourth_pizza = 0;
                                    оtotal_number_of_pizzas = 0;

                                    bonus_pizza_1 = 0;
                                    bonus_pizza_2 = 0;
                                    bonus_pizza_3 = 0;
                                    bonus_pizza_4 = 0;

                                    counting_pizza_valuable = 0;
                                    counting_bonus_pizzas = 0;

                                    tsykol_2_pizza = 0; tsykol_1_pizza++;
                                }
                                if (choice_action2_pizza >= 5)
                                {
                                    Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4\n" +
                                                  "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                                    choice_action2_pizza = 0;
                                    tsykol_2_pizza = 0; tsykol_1_pizza++;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Ошибка!Укажите индекс :1,2,3\n" +
                                                  "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                                tsykol_2_pizza = 0; tsykol_1_pizza++;

                            }




                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4"); Console.ReadLine(); --i;
                    }


                }

                for (int i = 1; i == tsykol_1_drinks; ++i)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine($"Меню \n" +
                                          $"Напитки :\n" +
                                          $"1){drink1}\t   :Cтоимость={value_of_drink_1}$\n" +
                                          $".\r\n═════════════█\r\n════════════███\r\n═════════█████████\r\n════════███████████\r\n═███═════█████████══════███\r\n██══█══█████████████═══███\r\n█════███████████████══███\r\n█════███████████████═███\r\n█════███████████████████═█████████████████\r\n█════██████████████████══███████████████═█\r\n██═████████████████████══███████████████═█\r\n═███═█████████████████═══███████████████═█\r\n══════████████████████═══███████████████═█\r\n═══════██████████████════████████████████\r\n═══════██████████████════███████████████\r\n════════████████████══════█████████████\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒═▒▒\r\n═▒▒▒═══▒▒▒═══▒▒▒═══▒▒▒═══▒▒▒═══▒▒▒══▒▒▒\r\n══▒═════▒═════▒═════▒═════▒═════▒═════▒\n\n" +
                                          $"2){drink2}\t   :Cтоимость={value_of_drink_2}$\n" +
                                          $"░░░░░╔════╗\r\n░░░░╔╝░░░░╚╗\r\n░░░░╚╗░░░░╔╝\r\n░░░░░║░░░░║\r\n░░░░░║░░░░║\r\n░░░░░║░░░░║\r\n░░░░░║░░░░║\r\n░░░░╔╝████╚╗\r\n░░░╔╝██████╚╗\r\n░░╔╝██╔══╗██╚╗\r\n░╔╝███║╔═╝███╚╗\r\n╔╝████║╚═╗████╚╗\r\n║█████╚══╝█████║\r\n║██████████████║\r\n║█████╔══╗█████║\r\n║█████║╔╗║█████║\r\n║█████║╚╝║█████║\r\n║█████╚══╝█████║\r\n║██████████████║ \r\n║█████╔╗███████║\r\n║█████║║███████║\r\n║█████║╚═╗█████║\r\n║█████╚══╝█████║\r\n║██████████████║\r\n║████╔════╗████║\r\n║████║╔══╗║████║ \r\n║████║╚══╝║████║\r\n║████║╔══╗║████║\r\n║███╔╝╚╗╔╝╚╗███║\r\n║███╚══╝╚══╝███║░\r\n╚╗████████████╔╝░\r\n░╚════════════╝░░\r\n░░░░░░░░░░░░░░░░░\n\n" +
                                          $"" +
                                          $"3){drink3}\t   :Cтоимость={value_of_drink_3}$\n" +
                                          $"═════════════█████████\r\n═════════════█████████\r\n═════════════█████████\r\n═════════════█████████\r\n═════════════▒▒▒▒▒▒▒▒▒\r\n═════════════█████████\r\n═════════════█████████\r\n═════════════█████████\r\n═════════════█████████\r\n════════════███████████\r\n═══════════█████████████\r\n══════════███████████████\r\n═════════█████████████████\r\n═════════███║═════════║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║▒▒▒▒▒▒▒▒▒║███\r\n═════════███║═════════║███\r\n═════════█████████████████\n\n" +
                                          $"\n\n\n");

                        Console.WriteLine("Выберете напито указав индекс :1,2,3");
                        drink = (drink_enum)int.Parse(Console.ReadLine());
                        switch (drink)
                        {
                            case drink_enum.drink1:
                                Console.Write("укажите количество:");
                                quantity_drink1 = int.Parse(Console.ReadLine());
                                tsykol_2_drinks++;
                                break;
                            case drink_enum.drink2:
                                Console.Write("укажите количество:");
                                quantity_drink2 = int.Parse(Console.ReadLine());
                                tsykol_2_drinks++;
                                break;
                            case drink_enum.drink3:
                                Console.Write("укажите количество:");
                                quantity_drink3 = int.Parse(Console.ReadLine());
                                tsykol_2_drinks++;
                                break;
                            default:
                                Console.WriteLine("Ошибка!Укажите индекс :1,2,3"); Console.ReadLine(); --i;
                                break;
                        }

                        total_number_of_drinks = quantity_drink1 + quantity_drink2 + quantity_drink3;
                        if (total_number_of_drinks > 0)
                        {

                            result_number_of_drinks_with_discount = ((quantity_drink3 * value_of_drink_3) / 100) * 85;
                            Console.WriteLine("\nДобавленно в корзину:");
                            if (quantity_drink1 > 0) Console.WriteLine($"{drink1}:\t{quantity_drink1}шт \tЦена" + (quantity_drink1 * value_of_drink_1) + "$");
                            if (quantity_drink2 > 0) Console.WriteLine($"{drink2}:\t{quantity_drink2}шт \tЦена" + (quantity_drink2 * value_of_drink_2) + "$");
                            if (quantity_drink3 >= 3) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "Цена с скидко 15%=" + (result_number_of_drinks_with_discount) + "$");
                            else if (quantity_drink3 > 0) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "$");

                            if (quantity_drink3 >= 3)
                            {
                                counting_drinks_price_with_discount = (quantity_drink1 * value_of_drink_1) + (quantity_drink2 * value_of_drink_2);
                                counting_drinks_valuable = counting_drinks_price_with_discount + result_number_of_drinks_with_discount;
                                amount_of_drinks_without_discount = counting_drinks_valuable;
                                Console.WriteLine($"\nОбщая цена={counting_drinks_valuable}$");
                            }
                            else
                            {
                                counting_drinks_valuable = (quantity_drink1 * value_of_drink_1) +
                                                (quantity_drink2 * value_of_drink_2) +
                                                (quantity_drink3 * value_of_drink_3);
                                amount_of_drinks_with_discount = counting_drinks_valuable;
                                Console.WriteLine($"\nЦена={counting_drinks_valuable}$");
                            }

                        }
                        else
                        {
                            Console.WriteLine("В корзине нечего нет:\n" +
                                              "Корзина очищена :");
                            quantity_drink1 = 0;
                            quantity_drink2 = 0;
                            quantity_drink3 = 0;

                            total_number_of_drinks = 0;

                            counting_drinks_valuable = 0;

                        }
                        for (int j = 1; j == tsykol_2_drinks; ++j)
                        {
                            try
                            {
                                Console.WriteLine("\n" +
                                         "Продолжить заказывать     нажмите:1\n" +
                                         "Оформить заказ            нажмите:2\n" +
                                         "Отменить всё и выйти      нажмите:3\n" +
                                         "Отменить всё и продолжить нажмите:4");

                                choice_actions2_drinks = int.Parse(Console.ReadLine());
                                if (choice_actions2_drinks == 1) { tsykol_2_drinks = 0; tsykol_1_drinks++; }
                                if (choice_actions2_drinks == 2) { tsykol_2_drinks = 0; tsykol_1_drinks = 0; }
                                if (choice_actions2_drinks == 3)
                                {
                                    quantity_drink1 = 0;
                                    quantity_drink2 = 0;
                                    quantity_drink3 = 0;

                                    total_number_of_drinks = 0;

                                    counting_drinks_valuable = 0;


                                    tsykol_2_drinks = 0; tsykol_1_drinks = 0;
                                }
                                if (choice_actions2_drinks == 4)
                                {
                                    quantity_drink1 = 0;
                                    quantity_drink2 = 0;
                                    quantity_drink3 = 0;

                                    total_number_of_drinks = 0;

                                    counting_drinks_valuable = 0;
                                    tsykol_2_drinks = 0; tsykol_1_drinks++;
                                }
                                if (choice_actions2_drinks >= 4)
                                {
                                    Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4\n" +
                                                  "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                                    choice_actions2_drinks = 0;
                                    tsykol_2_drinks = 0; tsykol_1_drinks++;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4\n" +
                                                  "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                                choice_actions2_drinks = 0;
                                tsykol_2_drinks = 0; tsykol_1_drinks++;

                            }

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка!Укажите индекс :1,2,3"); Console.ReadLine(); --i;
                    }

                }

                for (int i = 1; i == tsykol_third_my_order; ++i)
                {
                    Console.Clear();
                    //обнулить //потвердить и вывести чек на экран //пощитать всё ++
                    try
                    {


                        if (оtotal_number_of_pizzas > 0 || total_number_of_drinks > 0)
                        {
                            if (оtotal_number_of_pizzas > 0)
                            {
                                Console.WriteLine("Корзина:");

                                Console.WriteLine("\nПицца:");
                                if (number_of_pizza_first > 0 && bonus_pizza_1 > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:+{bonus_pizza_1}шт бонусная пицца\t     " + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                                else if (number_of_pizza_first > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:" + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                                if (quantity_of_second_pizza > 0 && bonus_pizza_2 > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:+{bonus_pizza_2}шт бонусная пицца\t     " + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                                else if (quantity_of_second_pizza > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                                if (number_of_thirds_pizza > 0 && bonus_pizza_3 > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:+{bonus_pizza_3}шт бонусная пицца\t     " + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                                else if (number_of_thirds_pizza > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:" + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                                if (quantity_of_fourth_pizza > 0 && bonus_pizza_4 > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:+{bonus_pizza_4}+шт бонусная пицца" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");
                                else if (quantity_of_fourth_pizza > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");

                            }
                            if (total_number_of_drinks > 0)
                            {
                                Console.WriteLine("\nНапитки:");
                                if (quantity_drink1 > 0) Console.WriteLine($"{drink1}:\t{quantity_drink1}шт \tЦена" + (quantity_drink1 * value_of_drink_1) + "$");
                                if (quantity_drink2 > 0) Console.WriteLine($"{drink2}:\t{quantity_drink2}шт \tЦена" + (quantity_drink2 * value_of_drink_2) + "$");
                                if (quantity_drink3 >= 3) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "Цена с скидко 15%=" + (result_number_of_drinks_with_discount) + "$");
                                else if (quantity_drink3 > 0) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "$");

                                Console.WriteLine("\n");
                            }
                            //сумма_напитков_с_скидкой

                            Total_order_amount1 = amount_of_drinks_without_discount + amount_of_drinks_with_discount + counting_pizza_valuable;
                            if (Total_order_amount1 < 50)
                            {
                                Console.WriteLine($"\nОбщая сума заказа:{Total_order_amount1}$");
                            }
                            else
                            {
                                Total_order_amount2 = amount_of_drinks_without_discount + amount_of_drinks_with_discount + counting_pizza_valuable;
                                Total_order_amount1 = (Total_order_amount1 / 100) * 80;

                                Console.WriteLine($"\nОбщая сума заказа:{Total_order_amount2}$ c учётом скидки 20%:{Total_order_amount1}$\n");
                            }

                            Console.WriteLine("1)Удалить всё из корзины :нажмите 1\n" +
                                              "2)Добавить в корзину ещё :нажмите 2\n" +
                                              "3)Потвердить заказ       :нажмите 3\n" +
                                              "4)Выйти                  :нажмите 4\n" +
                                              " Если общая сумма заказа больше 50$, то размер скидки составляет 20 % от суммы заказа;");


                            action_choice = int.Parse(Console.ReadLine());




                            if (action_choice == 1)
                            {
                                //обнуление напитки
                                quantity_drink1 = 0;
                                quantity_drink2 = 0;
                                quantity_drink3 = 0;

                                total_number_of_drinks = 0;

                                counting_drinks_valuable = 0;
                                //обнуление пицца
                                number_of_pizza_first = 0;
                                quantity_of_second_pizza = 0;
                                number_of_thirds_pizza = 0;
                                quantity_of_fourth_pizza = 0;

                                оtotal_number_of_pizzas = 0;

                                bonus_pizza_1 = 0;
                                bonus_pizza_2 = 0;
                                bonus_pizza_3 = 0;
                                bonus_pizza_4 = 0;

                                counting_pizza_valuable = 0;

                                counting_bonus_pizzas = 0;
                            }
                            if (action_choice == 2 || action_choice == 4)
                            {
                                tsykol_third_my_order = 0;
                            }
                            if (action_choice == 3)
                            {
                                Console.Clear();
                                Console.WriteLine($"Чек:                                  \n" +
                                                  $"Ваш номер заказа: №1                  \n");

                                if (оtotal_number_of_pizzas > 0)
                                {

                                    Console.WriteLine("Пицца:");
                                    if (number_of_pizza_first > 0 && bonus_pizza_1 > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:+{bonus_pizza_1}шт бонусная пицца\t     " + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                                    else if (number_of_pizza_first > 0) Console.WriteLine($"{pizza1}:{number_of_pizza_first}шт" + $"\t:" + "\tЦенна" + (number_of_pizza_first * pizza_price_1) + "$");
                                    if (quantity_of_second_pizza > 0 && bonus_pizza_2 > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:+{bonus_pizza_2}шт бонусная пицца\t     " + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                                    else if (quantity_of_second_pizza > 0) Console.WriteLine($"{pizza2}:{quantity_of_second_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_second_pizza * pizza_price_2) + "$");
                                    if (number_of_thirds_pizza > 0 && bonus_pizza_3 > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:+{bonus_pizza_3}шт бонусная пицца\t     " + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                                    else if (number_of_thirds_pizza > 0) Console.WriteLine($"{pizza3}:{number_of_thirds_pizza}шт" + $"\t:" + "\tЦенна" + (number_of_thirds_pizza * pizza_price_3) + "$");
                                    if (quantity_of_fourth_pizza > 0 && bonus_pizza_4 > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:+{bonus_pizza_4}+шт бонусная пицца" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");
                                    else if (quantity_of_fourth_pizza > 0) Console.WriteLine($"{pizza4}:{quantity_of_fourth_pizza}шт" + $"\t:" + "\tЦенна" + (quantity_of_fourth_pizza * pizza_price_4) + "$");
                                }
                                if (total_number_of_drinks > 0)
                                {
                                    Console.WriteLine("Напитки:");
                                    if (quantity_drink1 > 0) Console.WriteLine($"{drink1}:\t{quantity_drink1}шт \tЦена" + (quantity_drink1 * value_of_drink_1) + "$");
                                    if (quantity_drink2 > 0) Console.WriteLine($"{drink2}:\t{quantity_drink2}шт \tЦена" + (quantity_drink2 * value_of_drink_2) + "$");
                                    if (quantity_drink3 >= 3) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "Цена с скидко 15%=" + (result_number_of_drinks_with_discount) + "$");
                                    else if (quantity_drink3 > 0) Console.WriteLine($"{drink3}:\t{quantity_drink3}шт \tЦена" + (quantity_drink3 * value_of_drink_3) + "$");
                                }
                                Console.WriteLine($"\nСумма к оплате  :{Total_order_amount1}$ \n" +
                                                  $"По номеру чека заберёте заказ\n" +
                                                  $"Дата заказа:" + DateTime.Now);
                                Console.ReadKey();
                                //обнуление напитки
                                quantity_drink1 = 0;
                                quantity_drink2 = 0;
                                quantity_drink3 = 0;

                                total_number_of_drinks = 0;

                                counting_drinks_valuable = 0;
                                //обнуление пицца
                                number_of_pizza_first = 0;
                                quantity_of_second_pizza = 0;
                                number_of_thirds_pizza = 0;
                                quantity_of_fourth_pizza = 0;

                                оtotal_number_of_pizzas = 0;

                                bonus_pizza_1 = 0;
                                bonus_pizza_2 = 0;
                                bonus_pizza_3 = 0;
                                bonus_pizza_4 = 0;

                                counting_pizza_valuable = 0;

                                counting_bonus_pizzas = 0;

                            }



                        }
                        else
                        {
                            Console.WriteLine("Корзина пуста:" +
                                              "Выйти нажмите:Enter");
                            Console.ReadKey();
                            tsykol_third_my_order = 0;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка!Укажите индекс :1,2,3,4\n" +
                                          "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                        tsykol_third_my_order = 0;
                    }
                    //try
                    //{
                    //   выбор_действия = int.Parse(Console.ReadLine());
                    //}
                    //catch 
                    //{
                    //    Console.WriteLine("Ошибка!Укажите индекс :1,2,3\n" +
                    //                      "Нажмите Enter чтоб продолжить:"); Console.ReadKey();
                    //    цыкол_третий_Мой_заказ = 1; i=0 ;
                    //    throw;
                    //}fsymbols

                    tsykol_third_my_order = 0;
                }





            }//while ксонец цыкла;
        }
    }
}