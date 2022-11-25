// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.

Console.WriteLine("введите число A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetStepen(int num, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result = num * result;
    }
    return result;
}

Console.WriteLine($"число А в степени B = {GetStepen(num1, num2)}");



