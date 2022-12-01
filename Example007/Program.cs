// Программа принимает на вход число и проверяет, кратно ли оно одовременно 7 и 23
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0) 
Console.WriteLine("yes");
else
Console.WriteLine("no");