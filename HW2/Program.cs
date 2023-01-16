 Console.Clear();
 Console.Write("Введите первое число: ");
  int n=Convert.ToInt32(Console.ReadLine ());
   Console.Write("Введите второе число: ");
    int m=Convert.ToInt32(Console.ReadLine ());
     Console.Write("Введите третье число : ");
      int b=Convert.ToInt32(Console.ReadLine ());
       if (n>m && n>b) Console.WriteLine("Максимальное значение = "+n);
        else if (m>b) Console.WriteLine("Максимальное значение = "+m);
         else         
Console.WriteLine("Максимальное значение = "+b); 