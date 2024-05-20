//MAIN TASKS

//Task #1


Console.WriteLine("Введите 4-значное число:");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number * 1000;
int num2 = number * 100;
int num3 = number * 10;
int num4 = number;
Console.WriteLine(number);


////Task #2                  
Console.WriteLine("Введите 6-значное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число: {number}");
string result = number.ToString();                           //Для того чтобы сделать разворот числа я изменил тип данных из инта в строку 
char[] res = result.ToCharArray();                          //Далее взял чар чтобы присвоить ему значение строки которую взял прежде
Array.Reverse(res);                                        //Собственно делаю реверс определённого значения res который изначально был введённым числом пользователя
Console.WriteLine(res);

//// И вывожу его на экран. Возникла только 1 проблема которую я не смог решить, при попытке добавить текст в эту строку что-то по типу: "Вот ваше перевёрнутое число" у меня вместо всего результата выдавало System.Char[]



////ADDITIONAL TASKS



////Task #1                     


Console.WriteLine("Введите 1-ое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ье число:");                                  //Здесь думаю обьяснять от себя как я это сделал не нужно, все и так предельно легко и понятно)))
int num3 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2 + num3;
Console.WriteLine($"Сумма данных чисел: {sum}");
double avrg = sum / 3.0;
Console.WriteLine($"Среднее арифметическое данных чисел:{avrg}");

////Task #2

Console.WriteLine("Укажите стоимость ноутбука: ");
decimal price = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Укажите количество которое хотите приобрести:");
decimal amount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Укажите какую скидку вы имеете: ");                        //Здесь тоже все было довольно понятно для меня
decimal discount = Convert.ToDecimal(Console.ReadLine());
decimal discount1 = price * amount * (discount / 100);
decimal price1 = price * amount - discount1;
Console.WriteLine($"Цена за ваш заказ составляет: {price1}");


////Task #3
////Условие в задании не совсем точное как по мне.Если же +5% от продаж,то нам должны быть известны цены этих продаж. То-есть если же брать 5% просто за каждую сделку то можно взять ту же переменную не как 100$, а как 105$.


decimal salary = 100;
decimal percentage = 5;
Console.WriteLine("Укажите сколько сделок вы сделали в этом месяце:");
decimal amount = Convert.ToDecimal(Console.ReadLine());
decimal percentage1 = salary * (percentage / 100);
decimal percentage2 = (percentage1 * amount);
decimal finalsalary = salary * amount + percentage2;
Console.WriteLine($"Ваша зарплата в этом месяце составляет: {finalsalary}");


////Task #4

Console.WriteLine("Укажите размер файла:");
double GB = Convert.ToDouble(Console.ReadLine());               //Гигабайты файла
Console.WriteLine("Введите скорость интернета: ");
double B = Convert.ToDouble(Console.ReadLine());                //Скорость подключения в битах
double B1 = GB * 1024 * 1024 * 1024 * 8;                        //Переводим Гигабайты в биты ( Гигабайт - Мегабайт - Килобайт - байт - бит)
double Seconds = B1 / B;                                        //Секунды
double Minutes = Seconds / 60;                                  //Минуты
double Hours = Minutes / 60;                                    //Часы
double days = Hours / 24;                                       //Добавил еще дни, мало-ли кто-нибудь с микроволновки фильм скачивает))) Была бы точность еще бы и месяца добавил.  Задания классные,на практику хорошо даёт, Спасибо большое)
Console.WriteLine($"Осталось ждать:{days} дней, {Hours} часов, {Minutes} минут, {Seconds} секунд");
