//TASK 1


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 1 оценку:");
        int mark1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 2 оценку:");
        int mark2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 3 оценку:");
        int mark3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 4 оценку:");
        int mark4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 5 оценку:");
        int mark5 = int.Parse(Console.ReadLine());
        if (mark1 > 5 | mark2 > 5 | mark3 > 5 | mark4 > 5 | mark5 > 5)
        {
            Console.WriteLine("ОШИБКА. Оценка не может быть выше 5");
            return;
        }
        else
        {
            double AVRG = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;
            if (AVRG >= 4)
            {
                Console.WriteLine("Студент допущен к экзамену. Поздравляем!");

            }
            else
            {
                Console.WriteLine("Студент не допущен к экзамену. На пересдачу)");
            }
            Console.WriteLine($"Средний бал: {AVRG}");
        }

    }
}



//Мог еще с массивами сделать это задание, но решил сильно не выделяться.

//TASK 2

//Довольно лёгкое

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное.");
    number *= 3;
}
else
{
    Console.WriteLine("Число нечётное.");
    number /= 2;
}
Console.WriteLine(number);


//Task 3


Console.WriteLine("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Какую операцию желаете провести?(+ - * /)");
char operation = Console.ReadLine()[0];                            //Взял чар для того чтобы вписать символ.
double result = 0;                                                 //Взял дабл со значением 0, чтобы потом здесь хранился результат
switch (operation)                                                 // Сделал все свитчом, так как если бы писал через If else тут было бы очень много строк) Свитчом проще
{
    case '+':
        result = number1 + number2;
        break;
    case '-':
        result = number1 - number2;
        break;
    case '*':
        result = number1 * number2;
        break;
    case '/':
        if (number2 != 0)                                           //Сделал дополнительное условие что на 0 делить нельзя
        {
            result = number1 / number2;
        }
        else
        {
            Console.WriteLine("Делить на ноль нельзя. Плохо в школе учился :)");
            return;                                                 //Команда для того чтобы код остановился, и не выводилось число.
        }
        break;
}
Console.WriteLine($"Вот что получилось: {result}");


//ADDITIONAL TASKS


//TASK 1


double[] sales = new double[3];                           //Создал массив для того чтобы вписать данные о уровне продаж каждого из менеджеров
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите уровень продаж для менеджера {i + 1}: ");
    sales[i] = double.Parse(Console.ReadLine());
}
double[] salaries = new double[3];                           // так же создал массив для подсчета общей зарплаты в будущем
double[] Salary = new double[3];                             //И собственно подсчитал зарплату каждого менеджера без процентов, тоже сдела через массив
for (int i = 0; i < 3; i++)
{
    double SalaryBase = 200;                                 // Четкая ставка 200$ за одну продажу
    Salary[i] = SalaryBase * sales[i];                       // Подсчет количества продаж и зарплаты
}
for (int i = 0; i < 3; i++)                                  //Здесь уже перехожу к подсчету процентов и условиям того как они будут распределяться
{
    double percentage = 0;                                   //Сохранил данные о процентах в дабле, изначально придав ему значение 0

    if (Salary[i] < 500)                                    //Условия при которых будут приходить проценты
    {
        percentage = Salary[i] * 0.03; // 3%
    }
    else if (Salary[i] >= 500 & Salary[i] <= 1000)
    {
        percentage = Salary[i] * 0.05; //5%
    }
    else
    {
        percentage = Salary[i] * 0.08; //8%
    }

    salaries[i] = Salary[i] + percentage;                    //Подсчет зарплаты каждого менеджера с процентами
}
int bestManager = 0;                                         //Нахождение лучшего менеджера сделал так же через условие for используя данные которые использовал в прошлом, дав ему значение 0, чтобы данные обновлялись каждый раз
for (int i = 1; i < 3; i++)
{
    if (sales[i] > sales[bestManager])                       //Изначально у нас значение 0, но при каждой проверке это значение будет меняться. Допустим i = 1, у него 3 продажи, это самый первый "лучший менеджер", и как только 
    {                                                        //оно найдет новое значение которое больше 3, bestManager сразу изменит значение на то, в котором будет больше продаж
        bestManager = i;
    }
}
salaries[bestManager] += 200;                                //Добрасываем премию лучшему менеджеру
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Зарплата менеджера {i + 1}: {salaries[i]}");                //выводим зарплату каждого менеджера с процентами
}

Console.WriteLine($"Лучший менеджер: Менеджер {bestManager + 1} с продажами {sales[bestManager]}");               //Выводим лучшего менеджера и его зарплату в том числе
Console.WriteLine($"Его зарплата с премией: {salaries[bestManager]}");

//НУ ОЧЕНЬ СИЛЬНОЕ ЗАДАНИЕ. Делал его две ночи, в итоге повторил массивы))) Отличная практика на самом то деле)



//TASK 2

Console.WriteLine("Введите 6-значное число:");         //Вводим 6-значное число
string number = Console.ReadLine();

if (number.Length != 6)
{
    Console.WriteLine("Введено не 6-значное число. Попробуйте еще раз.");
    return;
}
char[] numbers = number.ToCharArray();           //Делаем из строки - char
char sigma = numbers[0];
numbers[0] = numbers[5];                         //Меняем 1 символ на 6
numbers[5] = sigma;                              //А 6 символ на 1

sigma = numbers[1];                              //Делаем то же самое с 2 и 5 символом
numbers[1] = numbers[4];
numbers[4] = sigma;

string result = new string(numbers);              //Преобразовываем чар обратно в строку
Console.WriteLine("Ваше число: " + result);       //И выводим результат



////TASK 3



Console.WriteLine("Введите месяц от 1 до 12: ");                        //Ну здесь вроде бы все легко
int Month = int.Parse(Console.ReadLine());
if (Month < 1 | Month > 12)
{
    Console.WriteLine("Введен неверный месяц.");
    return;
}
string season = Month switch                                            //Изначально хотел сделать все через If, но столкнулся с проблемкой, и решил сделать через switch
{
    12 or 1 or 2 => "Winter",
    3 or 4 or 5 => "Spring",
    6 or 7 or 8 => "Summer",
    9 or 10 or 11 => "Autumn",
};
Console.WriteLine($"Время года {season}");


//TASK 4

// С этим все напорядок сложнее, здесь уже тяжеловато. По-этому надеюсь вы покажете пример как это можно было написать) ибо у меня не получилось сделать программу которая бы работала)




