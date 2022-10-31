// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)  2, 4 -> 16
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень");     
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"{number}^{degree} = {Math.Pow(number, degree)}");
