Console.Clear();
int [] array = new int[8];
for (int i = 0; i < array.Length; i++)
array[i] = new Random() .Next(0,9999999);
Console.WriteLine($"Результат : [{string.Join(" , ", array)}]");
