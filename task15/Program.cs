Console.Clear();
Console.Write("введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<1 || n<6)
  Console.WriteLine("будний день");
  else
  Console.WriteLine("выходной");