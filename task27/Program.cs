﻿Console.Clear();
Console.Write("Введите значение: ");
int n = Convert.ToInt32(Console.ReadLine()), result=0;
while (n > 0)
{
result = result + n % 10;
n = n / 10;
}
Console.WriteLine(result);