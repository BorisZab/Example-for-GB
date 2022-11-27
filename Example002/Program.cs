// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = n * (-1);
// while (i <= n) // созадли цикл от - i до n
// {
//     Console.Write($"{i} ");// вывод переменой i
//     i = i + 1; //переход к следующему числу
// }

//Второе решение

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = (-1) * n; i<=n; i++ )
Console.Write( i + " ");