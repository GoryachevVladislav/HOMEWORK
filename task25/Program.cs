
Console.Clear();
Console.Write("Введите первое значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе значение: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= m; i++)
result = result * n;
Console.WriteLine(result);
