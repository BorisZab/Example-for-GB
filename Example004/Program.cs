// нахождение  двух случайных чисел  в отрезке от 10 до 99 и нахождение больших.

Console.Clear();
int n = new Random().Next(10, 100);
int n1= n / 10;
int n2 = n % 10;
Console.WriteLine($"Случайное число: {n}");
if (n1>n2)
Console.Write(n1);
else
Console.Write(n2);