// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!1");
Console.WriteLine("1");
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Приветствие пользователя
Console.WriteLine("Добро пожаловать в консольное приложение!");//demo123

// Основная логика программы
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");

// Ожидание завершения программы
Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
