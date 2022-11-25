// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int GetCount(int num)
{
     int sum = 0;
     while (num > 0)
     {
        sum = sum + num % 10;
        num = num / 10;
     }
     return sum;
}
int sumGetCount = GetCount(num1);
Console.WriteLine($"Сумма цифр в числе {num1} равна {sumGetCount}");
