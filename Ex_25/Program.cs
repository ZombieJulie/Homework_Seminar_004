/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

void getPow(int a, int b)
{
    Console.WriteLine($"{a}^{b} = {Math.Pow(a, b)}");
}
    
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

getPow(a, b);