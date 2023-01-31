void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); 
}
int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
      if (element % 2 == 0)
        count++; // count = count + 1;
    }
    return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел: {CountEvenInArray(array)}");