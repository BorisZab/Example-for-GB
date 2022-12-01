Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b % a == 0) 
Console.WriteLine("Кратно");
else
Console.WriteLine($"Не кратно {a % b}");
