/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет (645 -> 5; 78 -> третьей цифры нет; 32679 -> 6)
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit3 = 0;

if (number < 100)

{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
     digit3 = number % 10;
}

System.Console.WriteLine(digit3);