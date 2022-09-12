// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int a = 0; int b = 0;
    a = number / 10; b = a % 10;
    Console.WriteLine($"Вторая цифра числа {number} -> {b}");
}
else Console.WriteLine("Введите корректное число");