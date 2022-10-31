// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  452 -> 11   82 -> 10
Console.WriteLine("Введите число");
string Number = Console.ReadLine();
int Num = int.Parse(Number); 

var digits = Number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int summ = 0;
for (int i = 0; i < digits.Length; i++)
{
    summ = summ + digits[i];
}

Console.WriteLine(summ);