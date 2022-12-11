// Напишите программу, которая будет выводит сумму всех числес от 1 до n
// Console.Clear();
// Console.WriteLine("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((1+n)/2*n);

//Второй способ
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
    sum = sum + i;
Console.WriteLine(sum);