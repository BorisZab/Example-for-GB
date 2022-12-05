//Напишите программу которая принимает на вход число"N", и выдает таблицу квадратов чисел
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= n)
// {
// Console.Write($"{i*i} ");
// i = i+1;
// }

for(int i = 1; i<=n; i++)
Console.Write($"{i*i} ");