


using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string name;
int age;                                        //Все наши переменные.
string city;
Console.WriteLine("Введите имя пользователя:");
{
   name = Console.ReadLine();                               //Дает возможность выводить имя которое введёт пользователь.
   Console.WriteLine("Имя пользователя:" + name);            //Выводит данные которые ввёл пользователь.
    Console.WriteLine("Введите возраст пользователя:");
    {
        age = Convert.ToInt32(Console.ReadLine());             //Конвертируем переменную int в int32 для того чтобы процесс не заканчивался на предыдущей строке и можно было ввести данные вручную.
        Console.WriteLine("Возраст пользователя:" + age);
        Console.WriteLine("Введите место проживания пользователя:");
        {
            city = Console.ReadLine();                                            //Вводим Город в котором живет наш пользователь.
            Console.WriteLine("Место жительства пользователя:" + city);
            Console.WriteLine($"Добрый день, {name}. Вам {age} лет. Вы проживаете в городе {city}.");       //Выводим все записанные данные в отдельной строке.
        }

    }

}


