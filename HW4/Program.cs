Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), count = 2;
while (count <= a)
{
    Console.Write($"{count} ");
    count = count +2;
}
