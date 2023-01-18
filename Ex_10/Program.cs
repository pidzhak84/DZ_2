/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа (456 -> 5)
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit (int number)
{
    int digit23 = number % 100;
    int result = digit23 / 10;
    return result;
}

int XXX = SecondDigit(number);
Console.WriteLine($"Вторая цифра этого трехзначного числа {XXX} ");