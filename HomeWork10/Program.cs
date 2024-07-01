//TASK 1

using System;

class City
{

    public string CityName { get; set; }                         // Поля класа
    public string RegionName { get; set; }
    public string CountryName { get; set; }
    public int Population { get; set; }
    public string PostalCode { get; set; }
    public string PhoneCode { get; set; }


    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)             // Конструктор
    {
        CityName = cityName;
        RegionName = regionName;
        CountryName = countryName;
        Population = population;
        PostalCode = postalCode;
        PhoneCode = phoneCode;
    }


    public void GetCityInfo()                                // Метод для получения информации про город
    {
        Console.WriteLine($"Название города: {CityName}");
        Console.WriteLine($"Название региона: {RegionName}");
        Console.WriteLine($"Название страны: {CountryName}");
        Console.WriteLine($"Количество жителей: {Population}");
        Console.WriteLine($"Почтовый индекс: {PostalCode}");
        Console.WriteLine($"Телефонный код: {PhoneCode}");
        Console.WriteLine($"\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<City> cities = new List<City>();

        try
        {
            while (true)
            {
                Console.WriteLine("Введите название города:");                // Просим ввести данные от пользователя
                string cityName = Console.ReadLine();

                Console.WriteLine("Введите название региона:");
                string regionName = Console.ReadLine();

                Console.WriteLine("Введите название страны:");
                string countryName = Console.ReadLine();

                Console.WriteLine("Введите Количество жителей:");
                int population = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите почтовый индекс:");
                string postalCode = Console.ReadLine();

                Console.WriteLine("Введите телефонный код:");
                string phoneCode = Console.ReadLine();

                City userCity = new City(cityName, regionName, countryName, population, postalCode, phoneCode);              // Создаём новый экземпляр класса City для хранения в ней информации
                cities.Add(userCity);

                Console.WriteLine("Вы хотите добавить другой город? (да/нет)");
                string response = Console.ReadLine().ToLower();
                if (response != "да")
                {
                    break;
                }
            }
            Console.WriteLine("\nИнформация про все города:\n");
            foreach (var city in cities)
            {
                city.GetCityInfo();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}


//TASK 2

using System;
using System.Collections.Generic;

class Country
{
    public string CountryName { get; set; }
    public string ContinentName { get; set; }
    public int Population { get; set; }
    public string PhoneCode { get; set; }
    public string CapitalName { get; set; }
    public List<string> CityNames { get; set; }

    public Country(string countryName, string continentName, int population, string phoneCode, string capitalName, List<string> cityNames)
    {
        CountryName = countryName;
        ContinentName = continentName;
        Population = population;
        PhoneCode = phoneCode;
        CapitalName = capitalName;
        CityNames = cityNames;
    }

    public void GetCountryInfo()
    {
        Console.WriteLine($"Название страны: {CountryName}");
        Console.WriteLine($"Название континента: {ContinentName}");
        Console.WriteLine($"Количество жителей: {Population}");
        Console.WriteLine($"Телефонный код: {PhoneCode}");
        Console.WriteLine($"Название столицы: {CapitalName}");
        Console.WriteLine("Названия городов: ");
        foreach (var city in CityNames)
        {
            Console.WriteLine($"- {city}");
        }
        Console.WriteLine($"\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Country> countries = new List<Country>();

        try
        {
            while (true)
            {
                
                Console.WriteLine("Введите название страны:");
                string countryName = Console.ReadLine();

                Console.WriteLine("Введите название континента:");
                string continentName = Console.ReadLine();

                Console.WriteLine("Введите количество жителей страны:");
                int population = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите телефонный код страны:");
                string phoneCode = Console.ReadLine();

                Console.WriteLine("Введите название столицы:");
                string capitalName = Console.ReadLine();

                Console.WriteLine("Введите количество городов:");
                int cityCount = int.Parse(Console.ReadLine());

                List<string> cityNames = new List<string>();
                for (int i = 0; i < cityCount; i++)
                {
                    Console.WriteLine($"Введите название города {i + 1}:");
                    string cityName = Console.ReadLine();
                    cityNames.Add(cityName);
                }

                
                Country userCountry = new Country(countryName, continentName, population, phoneCode, capitalName, cityNames);
                countries.Add(userCountry);

                
                Console.WriteLine("Вы хотите добавить другую страну? (да/нет)");
                string response = Console.ReadLine().ToLower();
                if (response != "да")
                {
                    break;
                }
            }

            
            Console.WriteLine("\nИнформация о всех странах:\n");
            foreach (var country in countries)
            {
                country.GetCountryInfo();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}