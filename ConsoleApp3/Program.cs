// See https://aka.ms/new-console-template for more information
Console.Write("Напиши своё имя: ");
string some = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Привет, {some}.");
