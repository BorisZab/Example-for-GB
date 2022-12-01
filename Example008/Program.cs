// Программа на вход принимает 2 числа и проверяет 1 или 2 являеться квадратом другого
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a || a * a == b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");