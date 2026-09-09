using AutoServiceApp.Models;

// Створення двох об'єктів класів
Car car1 = new()
{
    Brand = "BMW",
    Model = "X5",
    Year = 2021
};

Car car2 = new()
{
    Brand = "Audi",
    Model = "A6",
    Year = 2019
};

Customer customer1 = new()
{
    Name = "Олександр Коваленко"
};

Customer customer2 = new()
{
    Name = "Марія Бойко"
};

// Вивід інформації у консоль
Console.WriteLine("Автомобілі:");
Console.WriteLine($"{car1.Brand} {car1.Model}, {car1.Year} р.");
Console.WriteLine($"{car2.Brand} {car2.Model}, {car2.Year} р.");

Console.WriteLine("\nКлієнти:");
Console.WriteLine($"Ім'я: {customer1.Name}");
Console.WriteLine($"Ім'я: {customer2.Name}");
