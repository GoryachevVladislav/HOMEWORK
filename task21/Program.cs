Console.Clear();
Console.Write("Введите координату x:" );
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y:" );
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z:" );
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x:" );
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y:" );
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z:" );
double z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine($"Результат: {Math.Round(S, 2)}");

