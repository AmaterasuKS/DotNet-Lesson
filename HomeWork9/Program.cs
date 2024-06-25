using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер домашнего телефона:");
        string homePhone = Console.ReadLine();
        Console.WriteLine("Введите номер мобильного телефона:");
        string mobilePhone = Console.ReadLine();
        Console.WriteLine("Введите вашу электронную почту:");
        string email = Console.ReadLine();
        Console.WriteLine("Введите ваше ФИО:");
        string fullName = Console.ReadLine();
        Console.WriteLine("Введите пароль:");
        string password = Console.ReadLine();

        Console.WriteLine($"Домашний номер телефона ({homePhone}): {ValidateHomePhone(homePhone)}");
        Console.WriteLine($"Мобильный номер телефона ({mobilePhone}): {ValidateMobilePhone(mobilePhone)}");
        Console.WriteLine($"Email ({email}): {ValidateEmail(email)}");
        Console.WriteLine($"ФИО клиента ({fullName}): {ValidateFullName(fullName)}");
        Console.WriteLine($"Пароль ({password}): {ValidatePassword(password)}");
    }

    static bool ValidateHomePhone(string homePhone)
    {
        try
        {
            string pattern = @"^\d{5,10}$";
            return Regex.IsMatch(homePhone, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка проверки домашнего номера телефона: {ex.Message}");
            return false;
        }
    }

    static bool ValidateMobilePhone(string mobilePhone)
    {
        try
        {
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(mobilePhone, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка проверки мобильного номера телефона: {ex.Message}");
            return false;
        }
    }

    static bool ValidateEmail(string email)
    {
        try
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,50}$";
            return Regex.IsMatch(email, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка проверки email: {ex.Message}");
            return false;
        }
    }

    static bool ValidateFullName(string fullName)
    {
        try
        {
            string pattern = @"^([A-ZА-ЯІЇЄ]{1}[a-zа-яіїє']{1,19}\s){2}[A-ZА-ЯІЇЄ]{1}[a-zа-яіїє']{1,19}$";
            return Regex.IsMatch(fullName, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка проверки ФИО: {ex.Message}");
            return false;
        }
    }

    static bool ValidatePassword(string password)
    {
        try
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,16}$";
            return Regex.IsMatch(password, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка проверки пароля: {ex.Message}");
            return false;
        }
    }
}