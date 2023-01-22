//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
double a = number / 10000;
int b = number / 1000 % 10;
int d = number / 10;
int e = number % 10;
if (a > 9) Console.WriteLine("Число не пятизначное.");
else
{
    if (a == e & b == d) Console.Write("Число полиндром.");
    else
    {
        Console.Write("Число не полиндром");
    }
}

