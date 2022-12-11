// Найти максиму из двух чилес 
// int numberMax(int n, int m)
// {
//     if (n > m)
//         return n;
//     return m;
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numberMax(n, m));






void numberMax(ref int n)
{
    n = n + 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
numberMax(ref n);
Console.WriteLine(n);